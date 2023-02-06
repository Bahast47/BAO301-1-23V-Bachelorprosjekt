from datetime import *
from string import Template

ContentBaseGuid = "b33221a7-1628-4016-b77b-eadf85d02bc3"
InnerContentBaseGuid = "202372f4-8e04-4f51-b7c9-13553a307b85"
EnumerationsClassGuid = "7a2867fe-f2db-4c9f-8956-8c05ad47d8c3"
EnumerationClassGuid = "7d08c6fb-28f7-4d30-b407-439e018d2402"

generated = datetime.now()

class Indent:
    _level = 0

    def __init__(self, startLevel = 0):
        self._level = startLevel
        if self._level < 0:
            self._level = 0

    def inc(self, size):
        return Indent(self._level + size)

    def render(self):
        return "    " * self._level

    def __iadd__(self, value):
        self._level += value
        if self._level < 0:
            self._level = 0
        return self

    def __isub__(self, value):
        self._level -= value
        if self._level < 0:
            self._level = 0
        return self

    def __add__(self, other):
        return self.render() + other

    def __radd__(self, other):
        return other + self.render()

def GetContentBase():
    return api.Native.ContentClasses.GetItem("ContentBase")

def GetInnerContentBase():
    return api.Native.ContentClasses.GetItem("InnerContentBase")

def GetParents(currentClass, incThis):
    result = []
    if incThis:
        c = currentClass
    else:
        c = currentClass.BaseClass

    while c != None:
        result.append(c)
        c = c.BaseClass

    return result

def FindMostCommonBaseClass(classCollection, inner):

    #Include checks for OData

    def validIndex(i, baseClasses):
        for list in baseClasses:
            if i >= len(list):
                return False
        return True

    def classesEqual(i, baseClasses):
        for list in baseClasses:
            if list[i] != baseClasses[0][i]:
                return False

        return True

    baseClasses = []

    classes = []
    for c in classCollection:
        classes.append(c)

    if len(classes) == 0:
        if inner:
            return GetInnerContentBase()
        else:
            return GetContentBase()

    for c in classes:
        cHierarchy = []

        base = c
        while base != None:
            cHierarchy.insert(0, base)
            base = base.BaseClass

        baseClasses.append(cHierarchy)

    i = 0
    while validIndex(i, baseClasses) and classesEqual(i, baseClasses):
        i += 1

    i -= 1

    if i >= 0:
        return baseClasses[0][i]
    else:
        if inner:
            return GetInnerContentBase()
        else:
            return GetContentBase()

def FindMostCommonBaseClassInfo(classCollection, inner):

    baseClass = FindMostCommonBaseClass(classCollection, inner)

    if baseClass != None:
        return baseClass.ClassName, baseClass.Namespace
    else:
        return None, None

def RenderSimpleGetProperty(prefix, contents, indent):
    return indent + prefix + " {\n" + \
        indent.inc(1) + "get {\n" + \
        indent.inc(2) + contents + "\n" + \
        indent.inc(1) + "}\n" + \
        indent + "}\n\n"

def GenerateEditNotice():
    return "// *******************************************\n" +\
           "//          W A F - AUTO GENERATED CODE       \n" +\
           "// Do not edit! File is regularly overwritten.\n" +\
           "// *******************************************\n\n"

def GenerateSummary(summary, indent):
    if indent == None:
        indent = Indent()

    return indent + "///<summary>\n" + \
       indent + "///" + summary + "\n" + \
       indent + "///</summary>\n"

def GetLocalName(str):
    if len(str) >= 1:
        return "_" + str[0].lower() + str[1:]
    else:
        return "_" + str.lower()

def PascalCase(str):
    list = str.split("_")
    result = ""
    for l in list:
        result += l.capitalize()
    return result




def ClassHeader(currentClass, useInheritance = True):
    
    classHeaderData = {"InnerContentClass": "public partial class ",
            "ContentClass": "public partial class ",
            "AbstractClass": "public abstract partial class ",
            "InnerContentInterface": "public partial interface ",
            "Interface": "public partial interface "}

    result = ""

    header = classHeaderData[currentClass.ClassType]

    result += header + currentClass.ClassName

    if useInheritance:
        baseClass = currentClass.BaseClass
        result += ": " + "WAF.Engine.Content" + (("." + baseClass.Namespace) if baseClass.Namespace != "" else "") + "." + baseClass.ClassName

        interfaces = currentClass.Interfaces

        for interface in interfaces:
            result += ", " + "WAF.Engine.Content" + (("." + interface.Namespace) if interface.Namespace != "" else "") + "." + interface.ClassName

    return result

def GetODataTypeName(c):
    setting = c.Settings.GetItem("ODataName")
    if len(setting.Value) > 0:
        return setting.Value
    else:
        return c.ClassName

def GetODataPropertyName(c):
    setting = c.Settings.GetItem("ODataName")
    if len(setting.Value) > 0:
        return setting.Value
    else:
        return c.CodeName

def FillPropertyTemplate(prop, templateStr):

    #TODO: Indent

    def GenerateRelationCast(prop):

        if prop.PropertyClass.BaseClass == "InnerContents":
            setting = prop.Settings.GetItem("InnerContentClasses")
            classes = [c for c in setting.Value]
            base = FindMostCommonBaseClass(classes, True)
            classOdata = GetODataTypeName(base)
            if base.Guid.ToString().lower() == InnerContentBaseGuid:
                cast = "(WAF.Engine.Content.InnerContentBase)"
            else:
                cast = ""
        elif prop.PropertyClass.BaseClass == "FileFolderProperty":
            setting = prop.Settings.GetItem("InnerContentClasses")
            classes = [c for c in setting.Value]
            base = FindMostCommonBaseClass(classes, True)

            classOdata = GetODataTypeName(base)
            if base.Guid.ToString().lower() == InnerContentBaseGuid:
                cast = "(WAF.Engine.Content.InnerContentBase)"
            else:
                cast = ""
        elif prop.PropertyClass.BaseClass == "ParentRelation":
            setting = prop.Settings.GetItem("ContentClasses")
            classes = [c for c in setting.Value]
            base = FindMostCommonBaseClass(classes, False)
            
            classOdata = GetODataTypeName(base)
            if base.Guid.ToString().lower() == ContentBaseGuid:
                cast = "(WAF.Engine.Content.ContentBase)"
            else:
                cast = ""
        elif prop.PropertyClass.BaseClass in ("Parent", "Child", "Relative"):
            relation = prop.Settings.GetItem("Relation").Value

            if prop.PropertyClass.BaseClass == "Parent":
                classes = [c for c in relation.Parents]
            else:
                classes = [c for c in relation.Children]

            base = FindMostCommonBaseClass(classes, False)

            classOdata = GetODataTypeName(base)
            if base.Guid.ToString().lower() == ContentBaseGuid:
                cast = "(WAF.Engine.Content.ContentBase)"
            else:
                cast = ""
        elif prop.PropertyClass.BaseClass in ("Parents", "Children", "Relatives"):
            relation = prop.Settings.GetItem("Relation").Value
            if prop.PropertyClass.BaseClass == "Parents":
                classes = [c for c in relation.Parents]
            else:
                classes = [c for c in relation.Children]
            base = FindMostCommonBaseClass(classes, False)
            classOdata = GetODataTypeName(base)
            if base.Guid.ToString().lower() == ContentBaseGuid:
                cast = "(WAF.Engine.Content.ContentBase)"
            else:
                cast = ""
        else:
            return "", "", "", "", ""

        classCore =  "WAF.Engine.Content." + (base.Namespace + "." if base.Namespace != "" else "") + base.ClassName;
        classAPI = "WAF.API." + (base.Namespace + "." if base.Namespace != "" else "Native.") + base.ClassName;
        classTS = "" + (base.Namespace + "." if base.Namespace != "" else "Native.") + base.ClassName;
        return cast, classCore, classOdata, classAPI, classTS

    templateValues = {}
    templateValues["PROPERTY_GUID"] = prop.Guid.ToString()
    templateValues["PROPERTY_NAME"] = prop.CodeName
    templateValues["PROPERTY_ODATA_NAME"] = GetODataPropertyName(prop)
    templateValues["_PROPERTY_NAME"] = GetLocalName(prop.CodeName)

    propClassGuid = prop.PropertyClass.Guid.ToString().lower()
    if propClassGuid == EnumerationsClassGuid or propClassGuid == EnumerationClassGuid:
        enumSetting = prop.Settings.GetItem("Enumeration")
        templateValues["ENUMERATION_TYPE_NAME"] = (enumSetting.Value.Namespace + "." if enumSetting.Value.Namespace != "" else "") + enumSetting.Value.CodeName

    dataValues = prop.DataValues
    i = 0
    for dataValue in dataValues:
        templateValues["DATAVALUE_GUID_" + str(i+1)] = dataValue.Guid.ToString()
        i += 1

    templateValues["RELATION_CAST"], templateValues["RELATION_CLASS"], templateValues["RELATION_ODATA_CLASS"], templateValues["API_RELATION_CLASS"], templateValues["TS_RELATION_CLASS"] = GenerateRelationCast(prop)

    template = Template(templateStr)

    result = template.substitute(templateValues) + "\n"
    if result == None:
        result = ""

    return result

def GenerateClasses(WAF, classes, generated, existingCoreFiles):

    def GenerateClass(currentClass, WAF, generated, existingCoreFiles):

        def GenerateUsings(currentClass):
            return "using System;\n" +\
                "using WAF.Common;\n" +\
                "using WAF.Definition;\n" +\
                "using WAF.Engine;\n" +\
                "using WAF.Engine.Content;\n" +\
                "using WAF.Engine.Content.Native;\n" +\
                "using WAF.Engine.Query;\n" +\
                "using WAF.Engine.Query.Advanced;\n" +\
                "using WAF.Engine.Property;\n" +\
                "using WAF.Data;\n" +\
                "using WAF.Data.Query;\n" +\
                "using WAF.Data.Query" + (("." + currentClass.Namespace) if currentClass.Namespace != "" else "") + ";\n" +\
                "using WAF.Data.Content;\n" +\
                "using WAF.Data.DataValue;\n" +\
                "using WAF.Presentation.Web;\n\n"

        def GenerateSerializableAttribute(currentClass, indent):

            if indent == None:
                indent = Indent()

            if currentClass.ClassType in ("ContentClass", "InnerContentClass"):
                return indent + "[Serializable]\n"
            elif currentClass.ClassType in ("AbstractClass", "InnerContentInterface", "Interface"):        
                return ""
            else:
                raise RuntimeError("Invalid class type! Class: " + currentClass.ClassName + ", ClassType: " + currentClass.ClassType) 

        def GenerateProperties(currentClass, indent):

            if indent == None:
                indent = Indent()

            code = ""

            properties = currentClass.Properties
            for prop in properties:
                propClass = prop.PropertyClass
        
                if currentClass.ClassType in ("InnerContentClass", "ContentClass", "AbstractClass"):
                    templateStr = propClass.Template
                elif currentClass.ClassType in ("InnerContentInterface", "Interface"):
                    templateStr = propClass.InterfaceTemplate
                else:
                    raise RuntimeError("Invalid class type! Class: " + currentClass.ClassName + ", ClassType: " + currentClass.ClassType) 

                code += FillPropertyTemplate(prop, templateStr) 
       
            return code

        def GenerateCoreMethods(currentClass, generated, indent):
            
            if indent == None:
                indent = Indent()
            
            result = ""

            if currentClass.ClassType in ("ContentClass", "AbstractClass"):
                result += indent + "public override IContent AddCulture(int lcid) {\n" + \
                   indent.inc(1) + "return _WAFSession.AddCulture<" + currentClass.ClassName + ">(NodeId, lcid);\n" + \
                   indent + "}\n"
                result += indent + "public override IContent AddRevision(int revision) {\n" + \
                   indent.inc(1) +"return _WAFSession.AddRevision<" + currentClass.ClassName + ">(NodeId, revision);\n" + \
                   indent + "}\n"
                result += indent + "public override IContent AddContent(int lcid, int revision) {\n" + \
                   indent.inc(1) + "return _WAFSession.AddContent<" + currentClass.ClassName + ">(NodeId, lcid, revision);\n" + \
                   indent + "}\n"
                result += GenerateSummary("The internal Id of the Ontology content class", indent);
                result += RenderSimpleGetProperty("public static new int ContentClassId", \
                   "return WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\");", \
                   indent)

            elif currentClass.ClassType in ("InnerContentClass"):
                result += GenerateSummary("The internal Id of the Ontology content class", indent);
                result += RenderSimpleGetProperty("public static new int ContentClassId", \
                   "return WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\");", \
                   indent)

            elif not currentClass.ClassType in ("Interface", "InnerContentInterface"):
                raise RuntimeError("Invalid class type! Class: " + currentClass.ClassName + ", ClassType: " + currentClass.ClassType) 

            return result

        def GenerateIndexes(currentClass, indent):

            result = ""

            properties = currentClass.Properties
            for property in properties:
                result += RenderSimpleGetProperty("public static int PropertyId" + property.CodeName, \
                   "return WAFID.GetPropertyId(\"" + property.Guid.ToString() + "\");", \
                   indent)

                dataValues = property.DataValues
                for dataValue in dataValues:

                    if dataValue.DataValueType == "EnumFlagsType":

                        for i in range(dataValue.EnumFlagEntries.Count):
                            result += RenderSimpleGetProperty("public static int DataValueId" + property.CodeName + PascalCase(dataValue.Name + dataValue.EnumFlagEntries.GetItem(i).Suffix), \
                                "return WAFID.GetDataValueId(\"" + dataValue.EnumFlagEntries.GetItem(i).Guid.ToString() + "\");", \
                                indent)
                    else:
                        result += RenderSimpleGetProperty("public static int DataValueId" + property.CodeName + PascalCase(dataValue.Name), \
                            "return WAFID.GetDataValueId(\"" + dataValue.Guid.ToString() + "\");", \
                            indent)

            return result

        def GenerateGetResetPropValue(currentClass, indent):
            result = ""

            if currentClass.ClassType in ("ContentClass", "AbstractClass", "InnerContentClass"):
                result += indent + "public override object GetProperty(int propertyId) {\n"

                indent += 1

                result += indent + "EnsureContentDataIndependence();\n"
        
                first = True
                properties = currentClass.Properties
                for property in properties:
                    propClass = property.PropertyClass
                    if propClass.BaseClass != "Empty":

                        result = result + indent

                        if first:
                            first = False
                        else:
                            result += "else "

                        result += "if (propertyId == WAFID.GetPropertyId(\"" + property.Guid.ToString() + "\")) {\n"

                        indent += 1

                        result += indent + "object init = " + property.CodeName + ";\n"
                        result += indent + "return " + GetLocalName(property.CodeName) + ";\n"

                        indent -= 1
                        result += indent + "}\n"

                result += indent + "return base.GetProperty(propertyId);\n"

                indent -= 1
                result += indent + "}\n"

                result += indent + "protected override void ResetPropertyValues() {\n"
                indent += 1

                for property in properties:
                    propClass = property.PropertyClass
                    if propClass.BaseClass != "Empty":
                        result += indent + GetLocalName(property.CodeName) + " = null;\n"

                result += indent + "base.ResetPropertyValues();\n"

                indent -= 1
                result += indent + "}\n"

            return result

        def GenerateClassQueryCode(currentClass, indent):
            
            def GetDataValueCountForEnum(enum):
                maxValue = 0
                for i in range(enum.Values.Count):
                    value = enum.Values.GetItem(i).Value
                    if (value > maxValue):
                        maxValue = value
        
                return maxValue / 32 + 1                 

            def BuildClassName(rootNamespace, shortNamespace, classNamePrefix, className):
                if len(shortNamespace) == 0:
                    return rootNamespace + "." + classNamePrefix + className
                else:
                    return rootNamespace + "." + shortNamespace + "." + classNamePrefix + className                       

            if currentClass.ClassType in ("Interface", "InnerContentClass", "InnerContentInterface"):
                return ""

            code = ""

            code += "namespace WAF.Data.Query" + (("." + currentClass.Namespace) if currentClass.Namespace != "" else "") + " {\n"
            indent += 1

            code += indent + "public abstract class Sql" + currentClass.ClassName + " {\n"
            indent += 1

            code += RenderSimpleGetProperty("public static SqlTable Table", \
               "return new SqlTable(\"" + currentClass.TableName + "\", WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\"));", \
               indent)

            code += indent + "public abstract partial class Field {\n"
            indent += 1

            code += RenderSimpleGetProperty("public static SqlFieldInteger ContentId", \
                "return new SqlFieldPrimaryInteger(\"content_id\", Table);", \
                indent)

            properties = currentClass.Properties
            for property in properties:
                dataValues = property.DataValues

                for dataValue in dataValues:
                    if dataValues.Count == 1:
                        dvName = property.CodeName
                    else:
                        dvName = property.CodeName + "_" + dataValue.Name

                    dictionary = {"BooleanType": "Boolean", "DateTimeType": "DateTime", "FloatType": "Float",
                     "IntegerType": "Integer", "ShortStringType": "ShortString", "LongStringType": "LongString"}

                    if dataValue.DataValueType == "EnumFlagsType":

                        for i in range(dataValue.EnumFlagEntries.Count):
                            code += RenderSimpleGetProperty("public static SqlFieldInteger " + dvName + dataValue.EnumFlagEntries.GetItem(i).Suffix,\
                                "return new SqlFieldInteger(\"" + dataValue.Name + dataValue.EnumFlagEntries.GetItem(i).Suffix + "\", Table, WAFID.GetDataValueId(\"" + dataValue.EnumFlagEntries.GetItem(i).Guid.ToString() + "\"));", \
                                indent)

                    else:
                        if not dataValue.DataValueType in dictionary:
                            raise RuntimeError("Unsupported datavalue type!")

                        type = dictionary[dataValue.DataValueType]

                        code += RenderSimpleGetProperty("public static SqlField" + type + " " + dvName, \
                            "return new SqlField" + type + "(\"" + dataValue.Name + "\", Table, WAFID.GetDataValueId(\"" + dataValue.Guid.ToString() + "\"));", \
                            indent)

            indent -= 1
            code += indent + "}\n"

            indent -= 1
            code += indent + "}\n"

            code += indent + "public class SqlAlias" + currentClass.ClassName + " : SqlAlias {\n"
            indent += 1

            code += indent + "public SqlAlias" + currentClass.ClassName + "()\n"
            code += indent.inc(1) + ": base(Sql" + currentClass.ClassName + ".Table) {\n"
            code += indent + "}\n"
            
            code += RenderSimpleGetProperty("public SqlExpressionFieldInteger ContentId", \
                "return new SqlExpressionFieldInteger(Sql" + currentClass.ClassName + ".Field.ContentId, this);", \
                indent)

            #TODO Indent

            properties = currentClass.Properties
            for property in properties:

                dataValues = property.DataValues
                for dataValue in dataValues:

                    if dataValues.Count == 1:
                        dvName = property.CodeName
                    else:
                        dvName = property.CodeName + "_" + dataValue.Name

                    dictionary = {"BooleanType": "Boolean", "DateTimeType": "DateTime", "FloatType": "Float",
                     "IntegerType": "Integer", "ShortStringType": "ShortString", "LongStringType": "LongString" }

                    #TODO fix

                    if dataValue.DataValueType == "EnumFlagsType":

                        for i in range(dataValue.EnumFlagEntries.Count):
                            code += RenderSimpleGetProperty("public SqlExpressionFieldInteger " + dvName + dataValue.EnumFlagEntries.GetItem(i).Suffix,\
                                "return new SqlExpressionFieldInteger(Sql" + currentClass.ClassName + ".Field." + dvName + dataValue.EnumFlagEntries.GetItem(i).Suffix + ", this);", \
                                indent)
                    else:
                        if not dataValue.DataValueType in dictionary:
                            raise RuntimeError("Unsupported datavalue type!")

                        type = dictionary[dataValue.DataValueType]

                        code += RenderSimpleGetProperty("public SqlExpressionField" + type + " " + dvName, \
                            "return new SqlExpressionField" + type + "(Sql" + currentClass.ClassName + ".Field." + dvName + ", this);", \
                            indent)

            indent -= 1
            code += indent + "}\n"
            
            indent -= 1
            code += indent + "}\n"

            code += indent + "namespace WAF.Engine.Query" + (("." + currentClass.Namespace) if currentClass.Namespace != "" else "") + " {\n"
            indent += 1
            code += indent + "[System.Serializable]\n"
            code += indent + "public partial class Aql" + currentClass.ClassName + "{\n"
            indent += 1

            code += RenderSimpleGetProperty("public static AqlPropertyInteger NodeId ", "return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyShortString Guid ", "return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyInteger SiteId ", "return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyInteger ContentId ", "return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyInteger Revision ", "return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyInteger AuthorId ", "return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyInteger TemplateId ", "return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyInteger ModuleId ", "return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyInteger LCID ", "return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyBoolean IsDerived ", "return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyBoolean IsPublished ", "return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyBoolean Hidden ", "return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyBoolean IsRevisionDeleted", "return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyBoolean IsNodeDeleted", "return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyInteger ContentClassId ", "return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyDateTime CreateDate ", "return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyDateTime ChangeDate ", "return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyDateTime PublishDate ", "return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyDateTime ReleaseDate ", "return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyDateTime RetainDate ", "return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)
            code += RenderSimpleGetProperty("public static AqlPropertyShortString Name ", "return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")); ", indent)

            for subClass in GetParents(currentClass, True):

                if subClass.Guid.ToString().lower() != ContentBaseGuid:
                    subClassSqlName = "WAF.Data.Query" + (("." + subClass.Namespace) if subClass.Namespace != "" else "") + ".Sql" + subClass.ClassName
                else:
                    subClassSqlName = "WAF.Data.Query.Sql" + subClass.ClassName

                properties = subClass.Properties
                for property in properties:
                    if property.PropertyClass.Guid.ToString().lower() == EnumerationsClassGuid:
                    
                        # Enumerations

                        enumTypeName = property.Settings.GetItem("Enumeration")
                        enum = enumTypeName.Value
                        enumType = "WAF.Engine.Content." + enum.Namespace + "." + enum.CodeName

                        contents = "" + indent

                        dataValues = property.DataValues
                        if dataValues.Count != 1:
                            raise RuntimeError("Incorrect number of data values in Enumerations property!")
                        if dataValues.GetItem(0).DataValueType != "EnumFlagsType":
                            raise RuntimeError("Incorrect type of data value in Enumerations property!")

                        dataValue = dataValues.GetItem(0)

                        for i in range(dataValue.EnumFlagEntries.Count):
                            contents += "new AqlPropertyInteger(" + subClassSqlName + ".Field." + property.CodeName + dataValue.EnumFlagEntries.GetItem(i).Suffix + ", WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\"))"
                            if i < dataValue.EnumFlagEntries.Count - 1:
                                contents += ",\n" + indent
                            else:
                                contents += "\n" + indent

                        code += RenderSimpleGetProperty("public static AqlExpressionEnumHelper<" + enumType + "> " + property.CodeName, \
                            "return new AqlExpressionEnumHelper<" + enumType + ">(\n" + contents + ");", \
                            indent)
                    
                        for i in range(dataValue.EnumFlagEntries.Count):
                            code += RenderSimpleGetProperty("public static AqlPropertyInteger " + property.CodeName + dataValue.EnumFlagEntries.GetItem(i).Suffix + "_IntField", \
                                "return new AqlPropertyInteger(" + subClassSqlName + ".Field." \
                                + property.CodeName + dataValue.EnumFlagEntries.GetItem(i).Suffix + ", WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\"));", \
                                indent)
                    else:
                        dataValues = property.DataValues

                        for dataValue in dataValues:
                            if dataValues.Count == 1:
                                dvName = property.CodeName
                            else:
                                dvName = property.CodeName + "_" + dataValue.Name

                            dictionary = {"BooleanType": "Boolean", "DateTimeType": "DateTime", "FloatType": "Float",
                                "IntegerType": "Integer", "ShortStringType": "ShortString", "LongStringType": "LongString"}

                            if not dataValue.DataValueType in dictionary:
                                raise RuntimeError("Unsupported datavalue type!")

                            type = dictionary[dataValue.DataValueType]

                            code += RenderSimpleGetProperty("public static AqlProperty" + type + " " + dvName, \
                                "return new AqlProperty" + type + "(" + subClassSqlName + ".Field." + dvName + ", WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\"));", \
                                indent)
                       
                    propClass = property.PropertyClass
                    propSettings = property.Settings   
                    if propClass.BaseClass in ("Parent", "Parents", "Relative", "Relatives", "Child", "Children"):
                        #TODO REMOVE WORKAROUND!
                        relSetting = propSettings.GetItem("Relation")
                        if relSetting != None:
                            relation = relSetting.Value
                            if relation != None:
                                commonParentsBaseClass, commonParentsBaseClassNamespace = FindMostCommonBaseClassInfo(relation.Parents, False)
                                
                                if commonParentsBaseClass == None or commonParentsBaseClassNamespace == None:
                                    commonParentsBaseClass = "IContent"
                                    commonParentsBaseClassNamespace = ""
                                
                                commonChildrenBaseClass, commonChildrenBaseClassNamespace = FindMostCommonBaseClassInfo(relation.Children, False)

                                if commonChildrenBaseClass == None or commonChildrenBaseClassNamespace == None:
                                    commonChildrenBaseClass = "IContent"
                                    commonChildrenBaseClassNamespace = ""
                                
                                nameParent = "new " + BuildClassName("WAF.Engine.Query", commonParentsBaseClassNamespace, "AqlAlias", commonParentsBaseClass) + "()"
                                nameChild = "new " + BuildClassName("WAF.Engine.Query", commonChildrenBaseClassNamespace, "AqlAlias", commonChildrenBaseClass) + "()"
                                nameRel = BuildClassName("WAF.Engine.Query", relation.Namespace, "Aql", relation.ClassName)

                                code += RenderSimpleGetProperty("public static AqlPropertyRelation " + property.CodeName, \
                                   "return new AqlPropertyRelation( WAFID.GetPropertyId(\"" + property.Guid.ToString().lower() + "\"), new AqlAliasRelation(" + nameParent + ", " + nameChild + ", " + nameRel + ".Relation));", \
                                   indent)
                    
            indent -= 1
            code += indent + "}\n"

            code += indent + "[System.Serializable]\n"
            code += indent + "public class AqlAlias" + currentClass.ClassName + "\n"
            
            baseClass = currentClass.BaseClass;
                                               
            aqlAliasBase = "WAF.Engine.Query" + (("." + baseClass.Namespace) if baseClass.Namespace != "" else "") + ".AqlAlias" + baseClass.ClassName

            code += indent.inc(1) + ": " + aqlAliasBase + "{\n\n"
            indent += 1

            code += indent + "public AqlAlias" + currentClass.ClassName + "()\n" + \
                indent.inc(1) + ": base(WAFID.GetContentClassId(\"" + currentClass.Guid.ToString() + "\")) {\n\n" + \
                indent + "}\n\n"
            
            code += indent + "public AqlAlias" + currentClass.ClassName + "(int contentClassId)\n" + \
                indent.inc(1) + ": base(contentClassId) {\n\n" + \
                indent + "}\n\n"
            
            properties = currentClass.Properties

            for property in properties:
                if property.PropertyClass.Guid.ToString().lower() == EnumerationsClassGuid:
                    enumTypeSetting = property.Settings.GetItem("Enumeration")
                    enum = enumTypeSetting.Value
                    enumType = "WAF.Engine.Content." + enum.Namespace + "." + enum.CodeName

                    dataValues = property.DataValues

                    if dataValues.Count != 1:
                        raise RuntimeError("Incorrect number of data values in Enumerations property!")
                    if dataValues.GetItem(0).DataValueType != "EnumFlagsType":
                        raise RuntimeError("Incorrect type of data value in Enumerations property!")

                    dataValue = dataValues.GetItem(0)

                    contents = ""
                    first = True

                    for i in range(dataValue.EnumFlagEntries.Count):

                        if first:
                            first = False
                        else:
                            contents += ", "
                            
                        dvName = property.CodeName + dataValue.EnumFlagEntries.GetItem(i).Suffix

                        contents += "new AqlExpressionPropertyInteger(Aql" + currentClass.ClassName + "." + dvName + "_IntField, this) \n"

                    code += RenderSimpleGetProperty("public AqlExpressionEnumHelper<" + enumType + "> " + property.CodeName, \
                       "return new AqlExpressionEnumHelper<" + enumType + ">(" + contents + ");", \
                       indent)


                else:

                    dataValues = property.DataValues
                    for dataValue in dataValues:
                        if dataValues.Count == 1:
                            dvName = property.CodeName
                        else:
                            dvName = property.CodeName + "_" + dataValue.Name

                        dictionary = {"BooleanType": "Boolean", "DateTimeType": "DateTime", "FloatType": "Float",
                            "IntegerType": "Integer", "ShortStringType": "ShortString", "LongStringType": "LongString" }

                        if not dataValue.DataValueType in dictionary:
                            raise RuntimeError("Unsupported datavalue type!")

                        type = dictionary[dataValue.DataValueType]

                        code += RenderSimpleGetProperty("public AqlExpressionProperty" + type + " " + dvName, \
                           "return new AqlExpressionProperty" + type + "(Aql" + currentClass.ClassName + "." + dvName + ", this);", \
                           indent)

            indent -= 1            
            code += indent + "}\n"

            indent -= 1
            code += indent + "}\n"

            return code

        indent = Indent()

        coreFolder = WAF
    
        if currentClass.Namespace != "":
            namespaceFolders = currentClass.Namespace.split(".")
    
            for folder in namespaceFolders:
                coreFolder = coreFolder.EnsureFolder(folder)

        # *** Core file ***

        coreFile = coreFolder.EnsureFile(currentClass.ClassName + ".cs")

        path = coreFile.Path(0) + coreFile.FileName(0)
        if path in existingCoreFiles:
            del existingCoreFiles[path]

        # *** Contents of the core file ***

        contents = GenerateEditNotice()
        contents += "\n"
        contents += GenerateUsings(currentClass)

        # Namespace start

        contents += "namespace WAF.Engine.Content" + (("." + currentClass.Namespace) if currentClass.Namespace != "" else "") + " {\n"
        
        indent += 1

        contents += GenerateSerializableAttribute(currentClass, indent)

        # Class start

        contents += indent + ClassHeader(currentClass) + " {\n"

        indent += 1

        contents += GenerateProperties(currentClass, indent)
        contents += GenerateCoreMethods(currentClass, generated, indent)
        contents += GenerateIndexes(currentClass, indent)
        contents += GenerateGetResetPropValue(currentClass, indent)

        indent -= 1

        # Class end
        contents += indent + "}\n"

        indent -= 1

        # Namespace end
        contents += indent + "}\n"

        # Query classes:

        contents += GenerateClassQueryCode(currentClass, indent)

        # *** Save to file ***

        file = None
        try:
            file = open(coreFile.Path(0) + coreFile.FileName(0), "w")
            file.write(contents)

        finally:
            if file != None:
                file.close()

    i = 0
    for c in classes:
        api.Ide.SetProgress("Generating content classes", (100 * (i + 1)) / classes.Count)

        # ContentBase
        if c.Guid.ToString().lower() not in (ContentBaseGuid, InnerContentBaseGuid):
            GenerateClass(c, WAF, generated, existingCoreFiles)
        i += 1

def GenerateRelationQueryCodeAndEnums(WAF, definition, existingCoreFiles):

    def GetCodeName(name):

        nextLetterUpperCase = True
        newName = ""
        for i in range(len(name)):
            if name[i] == '_':
                nextLetterUpperCase = True
            else:
                if nextLetterUpperCase:
                    newName += name[i].upper()
                else:
                    newName += name[i]
                nextLetterUpperCase = False

        return newName

    api.Ide.SetProgress("Generating relation query code and enumerations", 0)

    indent = Indent()

    code = ""

    code += GenerateEditNotice()
    code += indent + "using WAF.Data.Query;\n"
    code += indent + "using WAF.Engine.Query;\n"
    code += indent + "using WAF.Engine.Query.Advanced;\n\n"

    relations = definition.Relations
    for relation in relations:
        code += "namespace WAF.Data.Query" + (("." + relation.Namespace) if relation.Namespace != "" else "") + " {\n\n"
        indent += 1

        code += indent + "public abstract class Sql" + relation.ClassName + " {\n\n"
        indent += 1

        code += RenderSimpleGetProperty("public static SqlTable Table", \
            "return new SqlTable(\"" + relation.TableName + "\", TableId.RelationAbstract);", \
            indent)

        code += indent + "public abstract class Field {\n\n"
        indent += 1

        code += RenderSimpleGetProperty("public static SqlFieldInteger " + GetCodeName(relation.NameParents), \
            "return new SqlFieldPrimaryInteger(\"" + relation.NameParents + "\", Table);", \
            indent)
        code += RenderSimpleGetProperty("public static SqlFieldInteger " + GetCodeName(relation.NameChildren), \
            "return new SqlFieldPrimaryInteger(\"" + relation.NameChildren + "\", Table);", \
            indent)
        code += RenderSimpleGetProperty("public static SqlFieldInteger Listorder", \
            "return new SqlFieldInteger(\"listorder\", Table);", \
            indent)

        indent -= 1
        code += indent + "}\n"
        
        indent -= 1
        code += indent + "}\n"
        
        indent -= 1
        code += indent + "}\n"

    for relation in relations:
        code += indent + "namespace WAF.Engine.Query" + (("." + relation.Namespace) if relation.Namespace != "" else "") + "{\n\n"
        indent += 1

        code += indent + "[System.Serializable]\n"
        code += indent + "public abstract class Aql" + relation.ClassName + "{\n"
        indent += 1

        code += RenderSimpleGetProperty("public static AqlClassRelation Relation", \
            "return new AqlClassRelation( WAFID.GetRelationId(\"" + relation.Guid.ToString() + "\") );", \
            indent)

        indent -= 1
        code += indent + "}\n"
        
        indent -= 1
        code += indent + "}\n"

    for relation in relations:
        code += indent + "namespace WAF.Engine.Query" + (("." + relation.Namespace) if relation.Namespace != "" else "") + "{\n\n"
        indent += 1

        code += indent + "[System.Serializable]\n"
        code += indent + "public class AqlAlias" + relation.ClassName + ": AqlAliasRelation {\n\n"
        indent += 1

        code += indent + "public AqlAlias" + relation.ClassName + "(AqlAlias parent, AqlAlias child)\n"
        code += indent.inc(1) + " : base(parent, child, Aql" + relation.ClassName + ".Relation) {\n\n"
        code += indent + "}\n"

        code += indent + "public AqlAlias" + relation.ClassName + "(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)\n"
        code += indent.inc(1) + " : base(parent, child, Aql" + relation.ClassName + ".Relation, onParent ) {\n\n"
        code += indent + "}\n"
        code += indent + "public AqlAlias" + relation.ClassName + "(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)\n"
        code += indent.inc(1) + " : base(parent, child, Aql" + relation.ClassName + ".Relation, onChild ) {\n\n"
        code += indent + "}\n"
        code += indent + "public AqlAlias" + relation.ClassName + "(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)\n"
        code += indent.inc(1) + " : base(parent, child, Aql" + relation.ClassName + ".Relation, onParent, onChild ) {\n\n"
        code += indent + "}\n"

        indent -= 1
        code += indent + "}\n"

        indent -= 1
        code += indent + "}\n"

    for relation in relations:
        code += indent + "namespace WAF.Engine.Content" + (("." + relation.Namespace) if relation.Namespace != "" else "") + "{\n"
        indent += 1

        code += indent + "[System.Serializable]\n"
        code += indent + "public partial class " + relation.ClassName + ": WAF.Engine.Content.RelationBase {\n\n"
        indent += 1

        code += RenderSimpleGetProperty("public static int RelationId", \
            "return WAFID.GetRelationId(\"" + relation.Guid.ToString() + "\");", \
            indent)

        indent -= 1
        code += indent + "}\n"

        indent -= 1
        code += "}\n"

    # AqlEnumerations?

    enumerations = definition.Enumerations
    for enumeration in enumerations:
        code += indent + "namespace WAF.Engine.Content" + (("." + enumeration.Namespace) if enumeration.Namespace != "" else "") + "{\n\n"
        indent += 1
        code += indent + "public enum " + enumeration.CodeName + ": int{\n\n"
        indent += 1
        
        values = enumeration.Values
        for value in values:
            code += indent + value.CodeName + "=" + str(value.Value) + ",\n"
        
        indent -= 1
        code += indent + "}\n"
        
        indent -= 1
        code += indent + "}\n"

    relationFile = WAF.EnsureFile("AqlRelations.cs")

    path = relationFile.Path(0) + relationFile.FileName(0)
    if path in existingCoreFiles:
        del existingCoreFiles[path]        

    file = None
    try:
        file = open(relationFile.Path(0) + relationFile.FileName(0), "w")
        file.write(code)

    finally:
        if file != None:
            file.close()

def GenerateODataServiceCode(WAF, definition, native, existingCoreFiles):

    def TypeNameShort(c):
        if len(c.Namespace) > 0:
            return c.Namespace + "." + c.ClassName
        else:
            return c.ClassName

    def TypeName(c):
        return "WAF.Engine.Content." + TypeNameShort(c)

    def GetPluralName(singleName):
        if singleName[-1:] == "y":
            return singleName[:(len(singleName)-1)] + "ies"
        if singleName[-1:] == "s":
            return singleName + "es"
        return singleName + "s"

    def AppendODataProxy(c, indent):

        def InternalAppendODataProxy(c, innerContent, indent):

            code = ""

            if innerContent:
                code += indent + "[DataServiceKey(\"Id\")]\n"
                code += indent + "[IgnoreProperties(\"BaseContent\")]\n"
                code += indent + "[EntityPropertyMappingAttribute(\"Name\", SyndicationItemProperty.Title, SyndicationTextContentKind.Plaintext, true)]\n"

                proxyname = GetODataTypeName(c)
                name = TypeName(c)
            
                code += indent + "public partial class " + proxyname + " : IWAFDataInnerServiceProxy {\n\n"
                indent += 1

                code += RenderSimpleGetProperty("public WAF.Engine.Content.InnerContentBase BaseContent", \
                    "return _content;", \
                    indent)
                code += indent + "protected " + name + " _content;\n"
                code += indent + "int _listOrder;\n"
                code += indent + "public " + proxyname + "(" + name + " content) {\n\n"
                indent += 1
                code += "_content = content;\n"
                
                indent -= 1
                code += "}\n"
                code += indent + "public " + proxyname + "(" + name + " content, int listOrder) {\n\n"
                indent += 1
                
                code += indent + "_content = content;\n"
                code += indent + "_listOrder = listOrder;\n"
                
                indent -= 1
                code += indent + "}\n"
                code += RenderSimpleGetProperty("public int Id", \
                   "return _content.ContentId;", \
                   indent)                                               
                code += RenderSimpleGetProperty("public int ListOrder", \
                    "return _listOrder;", \
                    indent)
                code += RenderSimpleGetProperty("public string Name", \
                    "return _content.ToString();", \
                    indent)

                for subClass in GetParents(c, True):
                    properties = subClass.Properties
                    for property in properties:
                        oDataExposeAllProperties = api.Definition.Options.OData.Settings.GetItem("ODataExposeAllProperties")
                        oDataAllowSetting = property.Settings.GetItem("ODataAllow")

                        if oDataExposeAllProperties.Value or oDataAllowSetting.Value:
                            templateStr = property.PropertyClass.ODataTemplate
                            code += FillPropertyTemplate(property, templateStr)

                    indent -= 1
                    code += indent + "}\n"

            else:

                code += indent + "[DataServiceKey(\"Id\")]\n"
                code += indent + "[IgnoreProperties(\"BaseContent\")]\n"
                code += indent + "[EntityPropertyMappingAttribute(\"Name\", SyndicationItemProperty.Title, SyndicationTextContentKind.Plaintext, true)]\n"
                code += indent + "[EntityPropertyMappingAttribute(\"Author\", SyndicationItemProperty.AuthorName, SyndicationTextContentKind.Plaintext, true)]\n"
                code += indent + "[EntityPropertyMappingAttribute(\"Updated\", SyndicationItemProperty.Updated, SyndicationTextContentKind.Plaintext, true)]\n"

                proxyname = GetODataTypeName(c)
                name = TypeName(c)

                code += indent + "public partial class " + proxyname + " : IWAFDataServiceProxy {\n\n"
                indent += 1

                code += RenderSimpleGetProperty("public WAF.Engine.Content.ContentBase BaseContent", \
                    "return _content;", \
                    indent)
                code += indent + "protected " + name + " _content;\n"
                code += indent + "int _listOrder;\n"
                code += indent + "public " + proxyname + "(" + name + " content) {\n\n"
                indent += 1 
                code += indent + "_content = content;\n"
                
                indent -= 1
                code += indent + "}\n"
                code += indent + "public " + proxyname + "(" + name + " content, int listOrder) {\n\n"
                indent += 1
                
                code += indent + "_content = content;\n"
                code += indent + "_listOrder = listOrder;\n"
                
                indent -= 1
                code += indent + "}\n"
                code += RenderSimpleGetProperty("public int Id", \
                    "return _content.NodeId;", \
                    indent)
                code += RenderSimpleGetProperty("public int ListOrder", \
                    "return _listOrder;", \
                    indent)
            
                code += RenderSimpleGetProperty("public string ImageUrl", \
                    "return WAFContext.UrlFromRootToHost + _content.GetThumbnailUrl(0,0);", \
                    indent)
                code += RenderSimpleGetProperty("public string ThumbnailUrl", \
                    "return WAFContext.UrlFromRootToHost + _content.GetThumbnailUrl(200, 200);", \
                    indent)
                                              
                code += indent + "public string Name {\n"
                indent += 1
                code += indent + "get {\n"
                indent += 1
                code += indent + "return _content.Name;\n"
                indent -= 1
                code += indent + "}\n"
                code += indent + "set {\n\n"
                indent += 1
                code += indent + "_content.Name = value;\n"
                indent -= 1
                code += indent + "}\n"
                indent -= 1
                code += indent + "}\n"
                
                code += RenderSimpleGetProperty("public string Author", \
                    "return _content.AuthorName;", \
                    indent)
                code += RenderSimpleGetProperty("public DateTime Updated", \
                    "return _content.ChangeDate;", \
                    indent)
                code += RenderSimpleGetProperty("public DateTime Created", \
                    "return _content.CreateDate;", \
                    indent)

                for subClass in GetParents(c, True):
                    properties = subClass.Properties
                    for property in properties:
                        oDataExposeAllProperties = api.Definition.Options.OData.Settings.GetItem("ODataExposeAllProperties")
                        oDataAllowSetting = property.Settings.GetItem("ODataAllow")
  
                        if oDataExposeAllProperties.Value or oDataAllowSetting.Value:
                            templateStr = property.PropertyClass.ODataTemplate
                            code += FillPropertyTemplate(property, templateStr)

                indent -= 1
                code += indent + "}\n"

            return code

        if c.ClassType == "InnerContentClass":
            return InternalAppendODataProxy(c, True, indent)
        else:
            return InternalAppendODataProxy(c, False, indent)

    api.Ide.SetProgress("Generating OData service code", 0)

    code = ""
    indent = Indent()

    oDataEnabledSetting = api.Definition.Options.OData.Settings.GetItem("ODataEnabled")
    if oDataEnabledSetting.Value:

        code += GenerateEditNotice()
        code += indent + "\n"
        code += indent + "using System;\n"
        code += indent + "using System.Data.Services;\n"
        code += indent + "using System.Data.Services.Common;\n"
        code += indent + "using System.Collections.Generic;\n"
        code += indent + "using System.Linq;\n"
        code += indent + "using System.ServiceModel.Web;\n"
        code += indent + "using WAF.Presentation.Web;\n"
        code += indent + "using WAF.Common;\n"
        code += indent + "using WAF.Engine;\n"
        code += indent + "using WAF.Presentation.Web.General;\n\n"

        code += indent + "namespace WAF.Service {\n\n"
        indent += 1

        oDataExposeAllTypes = api.Definition.Options.OData.Settings.GetItem("ODataExposeAllTypes")

        allClasses = []
        customContentClasses = definition.ContentClasses
        for c in customContentClasses:
            allClasses.append(c)

        nativeContentClasses = native.ContentClasses
        for c in nativeContentClasses:
            allClasses.append(c)

        relevantClasses = []
        for c in allClasses:
            settings = c.Settings
            oDataReadSetting = settings.GetItem("ODataAllowRead")
            oDataWriteSetting = settings.GetItem("ODataAllowWrite")
            if oDataReadSetting.Value or oDataWriteSetting.Value or oDataExposeAllTypes.Value:
                relevantClasses.append(c)

        for c in relevantClasses:
            code += AppendODataProxy(c, indent)

        code += indent + "public partial class Contents : WAFODataService, IUpdatable {\n\n"
        indent += 1

        relevantClasses.sort(key = lambda c: GetODataTypeName(c))

        for c in relevantClasses:
            if c.ClassType == "InnerContentClass":
                code += RenderSimpleGetProperty("public IQueryable<" + GetODataTypeName(c) + "> " + GetPluralName(GetODataTypeName(c)), \
                    "return null;", \
                    indent)
                code += indent + ""
            else:
                code += indent + "public IQueryable<" + GetODataTypeName(c) + "> " + GetPluralName(GetODataTypeName(c)) + " {\n\n"
                indent += 1
                code += indent + "get {\n\n"
                indent += 1
                code += indent + "var l = Session.GetContents<" + TypeName(c) + ">();\n"
                code += indent + "foreach(var c in l) {\n\n"
                indent += 1
                    
                code += indent + "c.IgnoreContentDataIndependence = true;"
                    
                indent -= 1
                code += indent + "}\n"
                code += indent + "return l.Select(c => new " + GetODataTypeName(c) + "(c)).AsQueryable();\n"
                indent -= 1
                code += indent + "}\n"
                indent -= 1
                code += indent + "}\n"

        code += indent + "public void SetReference(object targetResource, string propertyName, object propertyValue) {\n\n"
        indent += 1
        code += indent + "((IUpdatable)this).SetValue(targetResource, propertyName, propertyValue);\n"
        indent -= 1
        code += indent + "}\n"
        indent -= 1
        code += indent + "}\n\n"

        code += indent + "[System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults = true)]\n"
        code += indent + "public partial class Data : DataService<Contents> {\n\n"
        indent += 1

        code += indent + "public static void InitializeService(DataServiceConfiguration config) {\n\n"
        indent += 1

        code += indent + "config.SetServiceOperationAccessRule(\"*\", ServiceOperationRights.All); \n"
        code += indent + "config.SetEntitySetAccessRule(\"*\", EntitySetRights.All);\n"
        code += indent + "config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;\n"

        indent -= 1
        code += indent + "}\n"
        indent -= 1
        code += indent + "}\n"
        indent -= 1
        code += indent + "}\n"

    else:

        code += "// OData services are disabled in OData options\n"

    oDataFile = WAF.EnsureFile("ODataService.cs")

    path = oDataFile.Path(0) + oDataFile.FileName(0)
    if path in existingCoreFiles:
        del existingCoreFiles[path]        

    file = None
    try:
        file = open(oDataFile.Path(0) + oDataFile.FileName(0), "w")
        file.write(code)

    finally:
        if file != None:
            file.close()

def GeneratePartialCode(WAF_Custom, classes):
    
    def GeneratePartialClass(currentClass, WAF_Custom):

        indent = Indent()

        customFolder = WAF_Custom
    
        if currentClass.Namespace != "":
            namespaceFolders = currentClass.Namespace.split(".")
    
            for folder in namespaceFolders:
                customFolder = customFolder.EnsureFolder(folder)

        if not customFolder.Exists(currentClass.ClassName + ".cs"):
            customFile = customFolder.EnsureFile(currentClass.ClassName + ".cs")

            code = ""

            code += indent + "/*\n"
            code += indent + "// WAF Custom. Add your own code here to customize the default behavior.\n"

            code += indent + "using System;\n"
            code += indent + "using WAF.Common;\n"
            code += indent + "using WAF.Definition;\n"
            code += indent + "using WAF.Engine;\n"
            code += indent + "using WAF.Engine.Content.Native;\n"
            code += indent + "using WAF.Engine.Query;\n"
            code += indent + "using WAF.Engine.Query.Advanced;\n"
            code += indent + "using WAF.Engine.Property;\n"
            code += indent + "using WAF.Data;\n"
            code += indent + "using WAF.Data.Query;\n"
            code += indent + "using WAF.Data.Query" + (("." + currentClass.Namespace) if currentClass.Namespace != "" else "") + ";\n"
            code += indent + "using WAF.Data.Content;\n"
            code += indent + "using WAF.Data.DataValue;\n\n"
            code += indent + "namespace WAF.Engine.Content" + (("." + currentClass.Namespace) if currentClass.Namespace != "" else "") + " {\n"

            code += "\n"

            indent += 1 # Namespace

            code += indent + ClassHeader(currentClass, False) + " {\n\n"

            indent += 1 # Class

            if currentClass.ClassType in ("ContentClass", "AbstractClass"):
                code += indent + "public override void OnInit() {\n\n" + indent.inc(1) + "base.OnInit();\n" + indent + "}\n\n"
                code += indent + "public override void OnNew() {\n\n" + indent.inc(1) + "base.OnNew();\n" + indent + "}\n\n"
                code += indent + "public override void OnBeforeInsert() {\n\n" + indent.inc(1) + " base.OnBeforeInsert();\n" + indent + "}\n\n"
                code += indent + "public override void OnBeforeUpdate() {\n\n" + indent.inc(1) + " base.OnBeforeUpdate();\n" + indent + "}\n\n"
                code += indent + "public override void OnAfterInsert() {\n\n" + indent.inc(1) + " base.OnAfterInsert();\n" + indent + "}\n\n"
                code += indent + "public override void OnAfterUpdate() {\n\n" + indent.inc(1) + " base.OnAfterUpdate();\n" + indent + "}\n\n"
                code += indent + "public override void OnAfterDelete(bool permanently) {\n\n" + indent.inc(1) + " base.OnAfterDelete(permanently);\n" + indent + "}\n\n"
            else:
                code += indent + "public override void OnBeforeInsert() {\n\n" + indent.inc(1) + " base.OnBeforeInsert();\n" + indent + "}\n\n"
                code += indent + "public override void OnBeforeUpdate() {\n\n" + indent.inc(1) + " base.OnBeforeUpdate();\n" + indent + "}\n\n"
                code += indent + "public override void OnAfterInsert() {\n\n" + indent.inc(1) + " base.OnAfterInsert();\n" + indent + "}\n\n"
                code += indent + "public override void OnAfterUpdate() {\n\n" + indent.inc(1) + " base.OnAfterUpdate();\n" + indent + "}\n\n"
            
            indent -= 1
            code += indent + "}\n"

            indent -= 1
            code += indent + "}\n"

            code += indent + "*/\n"

            # *** Save to file ***

            file = None
            try:
                file = open(customFile.Path(0) + customFile.FileName(0), "w")
                file.write(code)

            finally:
                if file != None:
                    file.close()    

    i = 0
    for c in classes:
        api.Ide.SetProgress("Generating custom classes", (100 * (i + 1)) / classes.Count)

        # ContentBase
        if c.Guid.ToString().lower() not in (ContentBaseGuid, InnerContentBaseGuid):
            GeneratePartialClass(c, WAF_Custom)
        i += 1

def SaveOntologyCopy(root):
    WAF = root.EnsureFolder("WAF")
    files = WAF.EnsureFolder("Files")
    definitions = files.EnsureFolder("Definitions")
    content = definitions.EnsureFile("Content.definition")
    path = content.Path(0) + content.FileName(0)
    api.Ide.SetProgress("Saving definition copy...", 0)
    api.Definition.Save(path)

def GetFiles(folder):
       
    def InternalGetFiles(folder, files):
        for i in range(folder.Count):
            item = folder.GetItem(i)
            if item.Kind == "File":
                files[item.Path(0) + item.FileName(0)] = item
            elif item.Kind == "Folder":
                InternalGetFiles(item, files)

    files = {}
    InternalGetFiles(folder, files)
    return files

def RemoveEmptyCoreFolders(WAF):

    def InternalRemoveFolders(folder):
        items = [folder.GetItem(i) for i in range(folder.Count)]
        for item in items:
            if item.Kind == "Folder":
                InternalRemoveFolders(item)

        if folder.Count == 0:
            folder.Delete()

    InternalRemoveFolders(WAF)

def GenerateCoreModel():

    api.Ide.SetProgress("Creating core project folders", 0)
    
    if api.Definition.CoreModelGenerationPath.strip() != "":
        path = api.Definition.CoreModelGenerationPath
        steps = path.split("\\")
        current = api.Ide.CoreModelGenerationProject

        for step in steps:
            if step.strip() != "":
                current = current.EnsureFolder(step)

        App_Code = current

    else:
        if api.Ide.CoreModelGenerationProject.IsWebsite:
            App_Code = api.Ide.CoreModelGenerationProject.EnsureFolder("App_Code")
        else:
            App_Code = api.Ide.CoreModelGenerationProject.EnsureFolder("Models")
     
    WAF = App_Code.EnsureFolder("WAF")
    WAF_Custom = App_Code.EnsureFolder("WAF_Custom")
    
    api.Ide.SetProgress("Listing existing core files...", 0)

    existingCoreFiles = GetFiles(WAF)

    GenerateClasses(WAF, api.Definition.ContentClasses, generated, existingCoreFiles)
    GeneratePartialCode(WAF_Custom, api.Definition.ContentClasses)
    
    GenerateRelationQueryCodeAndEnums(WAF, api.Definition, existingCoreFiles)
    if not api.IsFileSpecialEditableNativeFile:
        GenerateODataServiceCode(WAF, api.Definition, api.Native, existingCoreFiles)
    
    api.Ide.SetProgress("Removing old core files...", 0)
    
    i = 0
    for key, value in existingCoreFiles.iteritems():
        api.Ide.SetProgress("Removing old core files...", (100 * (i + 1)) / len(existingCoreFiles))
        value.Delete()
        i += 1
    
    api.Ide.SetProgress("Removing empty core folders...", 0)

    RemoveEmptyCoreFolders(WAF)

def GenerateAPIModel():

    def GenerateAPIProperty(currentProperty):
        templateStr = currentProperty.PropertyClass.TemplateAPI
        if not currentProperty.PropertyClass.TemplateAPI: return ""
        return FillPropertyTemplate(currentProperty, templateStr)
        
    def GenerateAPIClass(currentClass):
        code = "\n"
        
        namespace = currentClass.Namespace
        
        baseClass = currentClass.BaseClass.ClassName

        if currentClass.BaseClass.Guid.ToString().lower() == ContentBaseGuid: baseClassNamespace = "Native"
        elif currentClass.BaseClass.Guid.ToString().lower() == InnerContentBaseGuid: baseClassNamespace = "Native"
        else: baseClassNamespace = currentClass.BaseClass.Namespace

        code += "namespace WAF.API." + namespace + " {\n"
        code += "[ClassGuid(\"" + currentClass.Guid.ToString().lower() + "\")]\n"
        code += "public class " + currentClass.ClassName + " : WAF.API." + baseClassNamespace + "." + baseClass + " {\n"


        if currentClass.ClassType == "InnerContentClass":
            code += "public " + currentClass.ClassName + "(IInnerContentDataProvider dataProvider)\n"
        else:
            code += "public " + currentClass.ClassName + "(IContentDataProvider dataProvider)\n"

        code +=  ": base(dataProvider) {"
        code += "}\n"



        for p in currentClass.Properties:
            code += GenerateAPIProperty(p)
            
        code += "}\n"
        code += "}\n"
        #code += currentClass.ClassName + "\n"
        return code

    def GenerateAPIClasses(classes):
        code = ""
        i = 0
        for c in classes:
            api.Ide.SetProgress("Generating API content classes", (100 * (i + 1)) / classes.Count)
            if c.Guid.ToString().lower() not in (ContentBaseGuid, InnerContentBaseGuid):
                code += GenerateAPIClass(c)
        return code

    code = GenerateEditNotice()
    code += "using System;\n"
    code += "using System.Linq;\n"
    code += "using System.Collections.Generic;\n"

    if api.IsFileSpecialEditableNativeFile:
        code += "namespace WAF.API { public class NativeDefinition{ } };\n"
    else:
        code += "namespace WAF.API { public class CustomDefinition{ } };\n"

    if api.IsFileSpecialEditableNativeFile:
        code += GenerateAPIClasses(api.Native.ContentClasses)

    code += GenerateAPIClasses(api.Definition.ContentClasses)

    api.Ide.SetProgress("Creating API model file", 0)
    if api.Definition.APIModelGenerationPath.strip() != "":
        path = api.Definition.APIModelGenerationPath
        steps = path.split("\\")
        current = api.Ide.APIModelGenerationProject

        for step in steps:
            if step.strip() != "":
                current = current.EnsureFolder(step)

        Models = current

    else:
        Models = api.Ide.APIModelGenerationProject.EnsureFolder("Models")
     
    WAF = Models.EnsureFolder("WAF")
    
    codeFile = WAF.EnsureFile("APIModel.cs")

    file = None
    try:
        file = open(codeFile.Path(0) + codeFile.FileName(0), "w")
        file.write(code)
    finally:
        if file != None:
            file.close()    

def GenerateAPIRouteConfig():

    def GetAPIController(c):
        code = ""
#        code += "[EnableCors(origins: \"*\", headers: \"*\", methods: \"*\")]\n"
        if c.Guid.ToString().lower() == ContentBaseGuid: namespace = "Native"
        elif c.Guid.ToString().lower() == InnerContentBaseGuid: namespace = "Native"
        else: namespace = c.Namespace
        code += "public class " + namespace.replace(".", "_") + "_" + c.ClassName + "Controller : WAF.Server.Controllers.ContentController<WAF.API." + namespace + "." + c.ClassName + "> { \n"
        code += "public " + namespace.replace(".", "_") + "_" + c.ClassName + "Controller(AdminUIAPIControllerContext ctx) : base(ctx) {    }\n"
        code += "}\n"
        return code

    def GetAPIControllers(classes):
        code = ""
        for c in classes: 
            if c.ClassType in ("ContentClass"): 
                code += GetAPIController(c)
        return code
        
    code = GenerateEditNotice()

#    code += "using System.Web.Http;\n"
#    code += "using WAF.API;\n"
#    code += "using WAF.Server.Config;\n"
#    code += "\n"
#    code += "namespace App.Server {\n"
#    code += "public static class WAFApiConfig{\n"
#    code += "public static void Register(HttpConfiguration config) {\n"
#    code += "Runtime.Register<BaseDefinition>();\n"
#    code += "Runtime.Register<NativeDefinition>();\n"
#    code += "Runtime.Register<CustomDefinition>();\n"
#    code += "WAFRouting.RegisterRouting(config);\n"
#    code += "}\n"
#    code += "}\n"
#    code += "}\n"

    code += "using WAF.API;\n"
    code += "\n"
    code += "namespace WAF{\n"
    code += "public static class ApiConfig{\n"
    code += "public static void RegisterDataModel() {\n"
    code += "StaticContext.RegisterModelsInAssembly<BaseDefinition>();\n"
    code += "StaticContext.RegisterModelsInAssembly<NativeDefinition>();\n"
    code += "StaticContext.RegisterModelsInAssembly<CustomDefinition>();\n"
    code += "}\n"
    code += "}\n"
    code += "}\n"

    code += "\n"
    code += "\n"
    code += "public class WAFPropertyHandlerController : WAF.API.Web.WAFPropertyHandlerControllerBase{\n"
    code += "public WAFPropertyHandlerController(WAF.API.Web.WAFControllerContext ctx) : base(ctx) { }\n"
    code += "}\n";
    code += "\n"

    code += GetAPIControllers(api.Native.ContentClasses)
    code += GetAPIControllers(api.Definition.ContentClasses)

    api.Ide.SetProgress("Creating API controller file", 0)
    if api.Definition.ControllerGenerationPath.strip() != "":
        path = api.Definition.ControllerGenerationPath
        steps = path.split("\\")
        current = api.Ide.ControllerGenerationProject

        for step in steps:
            if step.strip() != "":
                current = current.EnsureFolder(step)

        ControllerBase = current

    else:
        ControllerBase = api.Ide.ControllerGenerationProject.EnsureFolder("Controllers")
     
    WAF = ControllerBase.EnsureFolder("WAF")
    
    codeFile = WAF.EnsureFile("APIControllers.cs")

    file = None
    try:
        file = open(codeFile.Path(0) + codeFile.FileName(0), "w")
        file.write(code)

    finally:
        if file != None:
            file.close()    

def GenerateTypeScript():
   
    def GenerateTypeScriptProperty(currentProperty):
        if currentProperty.CodeName == "DisplayName" : return ""
        if currentProperty.CodeName == "Url" : return ""
        templateStr = currentProperty.PropertyClass.TemplateTypeScript
        if not currentProperty.PropertyClass.TemplateTypeScript: return ""
        return FillPropertyTemplate(currentProperty, templateStr)
        
    def GenerateTypeScriptClass(currentClass):
        code = "\n"
        
        if currentClass.Guid.ToString().lower() not in (ContentBaseGuid, InnerContentBaseGuid): namespace = currentClass.Namespace
        else: namespace = "Native"

        code += "export class " + currentClass.ClassName

        if currentClass.Guid.ToString().lower() not in (ContentBaseGuid, InnerContentBaseGuid):
            baseClass = currentClass.BaseClass.ClassName
            if currentClass.BaseClass.Guid.ToString().lower() == ContentBaseGuid: baseClassNamespace = "Native"
            elif currentClass.BaseClass.Guid.ToString().lower() == InnerContentBaseGuid: baseClassNamespace = "Native"
            else: baseClassNamespace = currentClass.BaseClass.Namespace
            code += " extends " + baseClassNamespace + "." + baseClass
        elif currentClass.Guid.ToString().lower() in (ContentBaseGuid):
            code += " implements IContent"
        elif currentClass.Guid.ToString().lower() in (InnerContentBaseGuid):
            code += " implements IInnerContent"
        
        code += " {\n"

        #code += "isComplete: boolean = false;\n"
        #code += "static Namespace = \"" + namespace + "\";\n"
        #code += "static ClassName = \"" + currentClass.ClassName + "\";\n"
        code += "static meta = new ClassMeta(\"" + currentClass.Guid.ToString() + "\", \"" + namespace + "\", \"" + currentClass.ClassName + "\");\n"

        if currentClass.ClassType in ("ContentClass", "AbstractClass"):
            code += "static Id= \"Id\";\n"
            code += "Id: number;\n"
            code += "static SiteId= \"SiteId\";\n"
            code += "SiteId: number;\n"
            code += "static ContentId= \"ContentId\";\n"
            code += "ContentId: number;\n"
            code += "static ContentPath= \"ContentPath\";\n"
            code += "ContentPath: string;\n"
            code += "static Revision= \"Revision\";\n"
            code += "Revision: number;\n"
            code += "static LCID= \"LCID\";\n"
            code += "LCID: number;\n"
            code += "static ChangeDate= \"ChangeDate\";\n"
            code += "ChangeDate: string;\n"
            code += "static CreateDate= \"CreateDate\";\n"
            code += "CreateDate: string;\n"
            code += "static Guid= \"Guid\";\n"
            code += "Guid: string;\n"
            code += "static Url= \"Url\";\n"
            code += "Url: string;\n"
            code += "static ClassGuid= \"ClassGuid\";\n"
            code += "ClassGuid: string;\n"
            code += "static Name= \"Name\";\n"
            code += "Name: string;\n"
            code += "static DisplayName= \"DisplayName\";\n"
            code += "DisplayName: string;\n"
            code += "static Listorder= \"Listorder\";\n"
            code += "Listorder: number;\n"

            code += "static SiteGuid= \"SiteGuid\";\n"
            code += "SiteGuid: string;\n"

            code += "static Info = \"Info\";\n"
            code += "Info: IContentInfo;\n"

            
            code += "static query(session?: Session): WAFQuery<" + currentClass.ClassName + "> {\n"
            code += "if (session == null) session = APIContext.session;\n"
            code += "return session.query<" + currentClass.ClassName + ">(" + currentClass.ClassName + ");"
            code += "}\n"
        else:
            code += "static ContentId= \"ContentId\";\n"
            code += "ContentId: number;\n"
            code += "static Guid= \"Guid\";\n"
            code += "Guid: string;\n"
            code += "static ContentPath= \"ContentPath\";\n"
            code += "ContentPath: string;\n"
            code += "static ClassGuid= \"ClassGuid\";\n"
            code += "ClassGuid: string;\n"
            code += "static DisplayName= \"DisplayName\";\n"
            code += "DisplayName: string;\n"
           

        for p in currentClass.Properties:
            code += GenerateTypeScriptProperty(p)
            
        code += "}\n"

        return code

    def GenerateTypeScriptClasses(classes):
        code = ""
        i = 0
        for c in classes:
            api.Ide.SetProgress("Generating API content classes", (100 * (i + 1)) / len(classes))
            code += GenerateTypeScriptClass(c)
        return code

    def AddNamespaces(classes, namespaces):
        for currentClass in classes:
            if currentClass.Guid.ToString().lower() not in (ContentBaseGuid, InnerContentBaseGuid): namespace = currentClass.Namespace
            else: namespace = "Native"
            if (not namespace in namespaces) and (namespace is not None): 
                namespaces.add(namespace)

    def AddClassesByNamespace(classes, filteredNamespace, classesOfNamespace):
        for currentClass in classes:
            if currentClass.Guid.ToString().lower() not in (ContentBaseGuid, InnerContentBaseGuid): namespace = currentClass.Namespace
            else: namespace = "Native"
            if namespace == filteredNamespace: classesOfNamespace.append(currentClass)

    def GetCodeOfClasses(classes, namespaces):
        code = GenerateEditNotice()
        if api.IsFileSpecialEditableNativeFile:
            code += "import { Session, APIContext, WAFQuery, IContent, IInnerContent, ClassMeta, IContentInfo, FileInfo } from \"..\";\n"
        else:
            code += "import { Session, APIContext, WAFQuery, IContent, IInnerContent, ClassMeta, IContentInfo, FileInfo } from \"@relatude/api\";\n"
            code += "import * as Native from \"@relatude/api\";\n"
        
        for namespace in namespaces: code += "import * as " + namespace + " from \"./" + namespace + "\";\n"

        code += GenerateTypeScriptClasses(classes)
        return code

    namespaces = set()
    if api.IsFileSpecialEditableNativeFile: AddNamespaces(api.Native.GetClassesOrderedByInheritance(), namespaces)
    AddNamespaces(api.Definition.GetClassesOrderedByInheritance(), namespaces)

    codeByNamespace = {}

    for namespace in namespaces:
        classes = []
        if api.IsFileSpecialEditableNativeFile: 
            AddClassesByNamespace(api.Native.GetClassesOrderedByInheritance(), namespace, classes)
        AddClassesByNamespace(api.Definition.GetClassesOrderedByInheritance(), namespace, classes)
        if len(classes) > 0: codeByNamespace[namespace] = GetCodeOfClasses(classes, namespaces)

    api.Ide.SetProgress("Creating Typescript model file", 0)

    
    if api.Definition.TypeScriptGenerationPath.strip() != "":
        path = api.Definition.TypeScriptGenerationPath
        steps = path.split("\\")
        current = api.Ide.TypeScriptGenerationProject

        for step in steps:
            if step.strip() != "":
                current = current.EnsureFolder(step)

        WAFClient = current

    else:
        WAFClient = api.Ide.TypeScriptGenerationProject.EnsureFolder("WAF.Client")
     
    Models = WAFClient.EnsureFolder("Models")

    for namespace in namespaces:
        codeFile = Models.EnsureFile(namespace + ".ts")
        file = None
        try:
            file = open(codeFile.Path(0) + codeFile.FileName(0), "w")
            file.write(codeByNamespace[namespace])
        finally:
            if file != None:
                file.close()    

def Main():

    if not api.Verify():
        api.Ide.Show("Cannot generate code: there are errors in the ontology model!")
        return

    api.Ide.ShowProgressWindow()

    GenerateCoreModel()
    if api.IsNewSystem:
        GenerateAPIModel()
        GenerateAPIRouteConfig()
        if api.Definition.GenerateTypescript: GenerateTypeScript()
    else:
        SaveOntologyCopy(api.Ide.CoreServerProject)

    api.Ide.HideProgressWindow()

Main()





