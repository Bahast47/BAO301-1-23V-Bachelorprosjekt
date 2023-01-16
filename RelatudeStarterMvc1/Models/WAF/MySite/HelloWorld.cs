// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************


using System;
using WAF.Common;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content;
using WAF.Engine.Content.Native;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;
using WAF.Engine.Property;
using WAF.Data;
using WAF.Data.Query;
using WAF.Data.Query.MySite;
using WAF.Data.Content;
using WAF.Data.DataValue;
using WAF.Presentation.Web;

namespace WAF.Engine.Content.MySite {
    [Serializable]
    public partial class HelloWorld: WAF.Engine.Content.Native.HierarchicalContent {
        LongStringPropertyValue _ingress;
        public virtual string Ingress {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("e8e34289-4bdc-4520-ac2a-34fdf513ff9e"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("e8e34289-4bdc-4520-ac2a-34fdf513ff9e"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _ingressPicure;
        public virtual FilePropertyValue IngressPicure {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("d3b2dba9-6cd5-4e91-86b4-9b449303250f"),WAFID.GetDataValueId("0cac2ab5-5126-4659-82e2-cb3fb057d679"),WAFID.GetDataValueId("886aa6e7-1058-45c3-b8ae-2b64fb97f802"),WAFID.GetDataValueId("0925e2ea-b750-4d79-8358-6817a6168aa2"),WAFID.GetDataValueId("f67ff8b0-af62-484a-bb3a-2e28475d2a06"),WAFID.GetDataValueId("0dbf8bc2-9458-44ce-891d-bd57b40c2e1d"), ref _ingressPicure, this, WAFID.GetDataValueId("b31cd878-73d5-4825-ac9e-641c5de60d26")); }
        }
      
        HTMLPropertyValue _content;
        public virtual string Content {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("852fd620-c0d0-4394-bff0-6c28bbfa18cb"), ref _content, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("852fd620-c0d0-4394-bff0-6c28bbfa18cb"), ref _content, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> _files;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> Files{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase>.GetValue(WAFID.GetDataValueId("f7daf615-e788-48bd-a1ca-c2cd5d55f6c4"), ref _files, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<HelloWorld>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<HelloWorld>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<HelloWorld>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d");
            }
        }

        public static int PropertyIdIngress {
            get {
                return WAFID.GetPropertyId("fc864cce-8aac-4122-9ae8-2cf41b6d6bc9");
            }
        }

        public static int DataValueIdIngressIngress {
            get {
                return WAFID.GetDataValueId("e8e34289-4bdc-4520-ac2a-34fdf513ff9e");
            }
        }

        public static int PropertyIdIngressPicure {
            get {
                return WAFID.GetPropertyId("b31cd878-73d5-4825-ac9e-641c5de60d26");
            }
        }

        public static int DataValueIdIngressPicureIngressPicureFilename {
            get {
                return WAFID.GetDataValueId("0cac2ab5-5126-4659-82e2-cb3fb057d679");
            }
        }

        public static int DataValueIdIngressPicureIngressPicureTypeName {
            get {
                return WAFID.GetDataValueId("886aa6e7-1058-45c3-b8ae-2b64fb97f802");
            }
        }

        public static int DataValueIdIngressPicureIngressPicureExtension {
            get {
                return WAFID.GetDataValueId("0925e2ea-b750-4d79-8358-6817a6168aa2");
            }
        }

        public static int DataValueIdIngressPicureIngressPicureBytes {
            get {
                return WAFID.GetDataValueId("f67ff8b0-af62-484a-bb3a-2e28475d2a06");
            }
        }

        public static int DataValueIdIngressPicureIngressPicureInfo {
            get {
                return WAFID.GetDataValueId("0dbf8bc2-9458-44ce-891d-bd57b40c2e1d");
            }
        }

        public static int DataValueIdIngressPicureIngressPicureInt {
            get {
                return WAFID.GetDataValueId("d3b2dba9-6cd5-4e91-86b4-9b449303250f");
            }
        }

        public static int PropertyIdContent {
            get {
                return WAFID.GetPropertyId("6efcf974-a668-46cc-bb9e-0cfec8306a17");
            }
        }

        public static int DataValueIdContentContent {
            get {
                return WAFID.GetDataValueId("852fd620-c0d0-4394-bff0-6c28bbfa18cb");
            }
        }

        public static int PropertyIdFiles {
            get {
                return WAFID.GetPropertyId("f7daf615-e788-48bd-a1ca-c2cd5d55f6c4");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("fc864cce-8aac-4122-9ae8-2cf41b6d6bc9")) {
                object init = Ingress;
                return _ingress;
            }
            else if (propertyId == WAFID.GetPropertyId("b31cd878-73d5-4825-ac9e-641c5de60d26")) {
                object init = IngressPicure;
                return _ingressPicure;
            }
            else if (propertyId == WAFID.GetPropertyId("6efcf974-a668-46cc-bb9e-0cfec8306a17")) {
                object init = Content;
                return _content;
            }
            else if (propertyId == WAFID.GetPropertyId("f7daf615-e788-48bd-a1ca-c2cd5d55f6c4")) {
                object init = Files;
                return _files;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _ingress = null;
            _ingressPicure = null;
            _content = null;
            _files = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlHelloWorld {
        public static SqlTable Table {
            get {
                return new SqlTable("hello_world", WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString Ingress {
                get {
                    return new SqlFieldLongString("ingress", Table, WAFID.GetDataValueId("e8e34289-4bdc-4520-ac2a-34fdf513ff9e"));
                }
            }

            public static SqlFieldShortString IngressPicure_ingress_picure_filename {
                get {
                    return new SqlFieldShortString("ingress_picure_filename", Table, WAFID.GetDataValueId("0cac2ab5-5126-4659-82e2-cb3fb057d679"));
                }
            }

            public static SqlFieldShortString IngressPicure_ingress_picure_type_name {
                get {
                    return new SqlFieldShortString("ingress_picure_type_name", Table, WAFID.GetDataValueId("886aa6e7-1058-45c3-b8ae-2b64fb97f802"));
                }
            }

            public static SqlFieldShortString IngressPicure_ingress_picure_extension {
                get {
                    return new SqlFieldShortString("ingress_picure_extension", Table, WAFID.GetDataValueId("0925e2ea-b750-4d79-8358-6817a6168aa2"));
                }
            }

            public static SqlFieldFloat IngressPicure_ingress_picure_bytes {
                get {
                    return new SqlFieldFloat("ingress_picure_bytes", Table, WAFID.GetDataValueId("f67ff8b0-af62-484a-bb3a-2e28475d2a06"));
                }
            }

            public static SqlFieldLongString IngressPicure_ingress_picure_info {
                get {
                    return new SqlFieldLongString("ingress_picure_info", Table, WAFID.GetDataValueId("0dbf8bc2-9458-44ce-891d-bd57b40c2e1d"));
                }
            }

            public static SqlFieldInteger IngressPicure_ingress_picure_int {
                get {
                    return new SqlFieldInteger("ingress_picure_int", Table, WAFID.GetDataValueId("d3b2dba9-6cd5-4e91-86b4-9b449303250f"));
                }
            }

            public static SqlFieldLongString Content {
                get {
                    return new SqlFieldLongString("content", Table, WAFID.GetDataValueId("852fd620-c0d0-4394-bff0-6c28bbfa18cb"));
                }
            }

        }
    }
    public class SqlAliasHelloWorld : SqlAlias {
        public SqlAliasHelloWorld()
            : base(SqlHelloWorld.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlHelloWorld.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString Ingress {
            get {
                return new SqlExpressionFieldLongString(SqlHelloWorld.Field.Ingress, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicure_ingress_picure_filename {
            get {
                return new SqlExpressionFieldShortString(SqlHelloWorld.Field.IngressPicure_ingress_picure_filename, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicure_ingress_picure_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlHelloWorld.Field.IngressPicure_ingress_picure_type_name, this);
            }
        }

        public SqlExpressionFieldShortString IngressPicure_ingress_picure_extension {
            get {
                return new SqlExpressionFieldShortString(SqlHelloWorld.Field.IngressPicure_ingress_picure_extension, this);
            }
        }

        public SqlExpressionFieldFloat IngressPicure_ingress_picure_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlHelloWorld.Field.IngressPicure_ingress_picure_bytes, this);
            }
        }

        public SqlExpressionFieldLongString IngressPicure_ingress_picure_info {
            get {
                return new SqlExpressionFieldLongString(SqlHelloWorld.Field.IngressPicure_ingress_picure_info, this);
            }
        }

        public SqlExpressionFieldInteger IngressPicure_ingress_picure_int {
            get {
                return new SqlExpressionFieldInteger(SqlHelloWorld.Field.IngressPicure_ingress_picure_int, this);
            }
        }

        public SqlExpressionFieldLongString Content {
            get {
                return new SqlExpressionFieldLongString(SqlHelloWorld.Field.Content, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlHelloWorld{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")); 
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlHelloWorld.Field.Ingress, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyShortString IngressPicure_ingress_picure_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicure_ingress_picure_filename, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyShortString IngressPicure_ingress_picure_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicure_ingress_picure_type_name, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyShortString IngressPicure_ingress_picure_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicure_ingress_picure_extension, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyFloat IngressPicure_ingress_picure_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicure_ingress_picure_bytes, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyLongString IngressPicure_ingress_picure_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicure_ingress_picure_info, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyInteger IngressPicure_ingress_picure_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlHelloWorld.Field.IngressPicure_ingress_picure_int, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyLongString Content {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlHelloWorld.Field.Content, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyRelation ContentTags {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a4e4d56c-8ff9-4ede-9232-094e72398668"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasContentTag(), WAF.Engine.Query.Native.AqlRelTaxonomyHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Children {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("cc90eccd-1d77-40c8-aab7-5262842a66e2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Parent {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a1eca898-8f93-4522-a46c-669c56af9b55"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyBoolean ShowInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasHelloWorld
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasHelloWorld()
            : base(WAFID.GetContentClassId("405504e2-9586-4c8d-8f05-9a0b3c02a05d")) {

        }

        public AqlAliasHelloWorld(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString Ingress {
            get {
                return new AqlExpressionPropertyLongString(AqlHelloWorld.Ingress, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicure_ingress_picure_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlHelloWorld.IngressPicure_ingress_picure_filename, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicure_ingress_picure_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlHelloWorld.IngressPicure_ingress_picure_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString IngressPicure_ingress_picure_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlHelloWorld.IngressPicure_ingress_picure_extension, this);
            }
        }

        public AqlExpressionPropertyFloat IngressPicure_ingress_picure_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlHelloWorld.IngressPicure_ingress_picure_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString IngressPicure_ingress_picure_info {
            get {
                return new AqlExpressionPropertyLongString(AqlHelloWorld.IngressPicure_ingress_picure_info, this);
            }
        }

        public AqlExpressionPropertyInteger IngressPicure_ingress_picure_int {
            get {
                return new AqlExpressionPropertyInteger(AqlHelloWorld.IngressPicure_ingress_picure_int, this);
            }
        }

        public AqlExpressionPropertyLongString Content {
            get {
                return new AqlExpressionPropertyLongString(AqlHelloWorld.Content, this);
            }
        }

    }
}
