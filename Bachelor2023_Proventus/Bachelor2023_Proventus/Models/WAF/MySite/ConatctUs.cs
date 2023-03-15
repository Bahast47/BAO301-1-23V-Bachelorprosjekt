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
    public partial class ConatctUs: WAF.Engine.Content.Native.HierarchicalContent {
        HTMLPropertyValue _formContainer;
        public virtual string FormContainer {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("b0707483-6ad7-4073-8b1c-cc8013ddaef9"), ref _formContainer, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("b0707483-6ad7-4073-8b1c-cc8013ddaef9"), ref _formContainer, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        HTMLPropertyValue _signUp;
        public virtual string SignUp {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("2aea76c9-f493-42a4-b144-8543279dc534"), ref _signUp, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("2aea76c9-f493-42a4-b144-8543279dc534"), ref _signUp, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ConatctUs>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ConatctUs>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ConatctUs>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75");
            }
        }

        public static int PropertyIdFormContainer {
            get {
                return WAFID.GetPropertyId("eaf8f447-4825-44d1-9cc8-c9b85f682b36");
            }
        }

        public static int DataValueIdFormContainerFormContainer {
            get {
                return WAFID.GetDataValueId("b0707483-6ad7-4073-8b1c-cc8013ddaef9");
            }
        }

        public static int PropertyIdSignUp {
            get {
                return WAFID.GetPropertyId("b8174d88-664d-4190-8fd5-0dc46e26949c");
            }
        }

        public static int DataValueIdSignUpSignUp {
            get {
                return WAFID.GetDataValueId("2aea76c9-f493-42a4-b144-8543279dc534");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("eaf8f447-4825-44d1-9cc8-c9b85f682b36")) {
                object init = FormContainer;
                return _formContainer;
            }
            else if (propertyId == WAFID.GetPropertyId("b8174d88-664d-4190-8fd5-0dc46e26949c")) {
                object init = SignUp;
                return _signUp;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _formContainer = null;
            _signUp = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlConatctUs {
        public static SqlTable Table {
            get {
                return new SqlTable("conatct_us", WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString FormContainer {
                get {
                    return new SqlFieldLongString("form_container", Table, WAFID.GetDataValueId("b0707483-6ad7-4073-8b1c-cc8013ddaef9"));
                }
            }

            public static SqlFieldLongString SignUp {
                get {
                    return new SqlFieldLongString("sign_up", Table, WAFID.GetDataValueId("2aea76c9-f493-42a4-b144-8543279dc534"));
                }
            }

        }
    }
    public class SqlAliasConatctUs : SqlAlias {
        public SqlAliasConatctUs()
            : base(SqlConatctUs.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlConatctUs.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString FormContainer {
            get {
                return new SqlExpressionFieldLongString(SqlConatctUs.Field.FormContainer, this);
            }
        }

        public SqlExpressionFieldLongString SignUp {
            get {
                return new SqlExpressionFieldLongString(SqlConatctUs.Field.SignUp, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlConatctUs{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")); 
            }
        }

        public static AqlPropertyLongString FormContainer {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlConatctUs.Field.FormContainer, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyLongString SignUp {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlConatctUs.Field.SignUp, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasConatctUs
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasConatctUs()
            : base(WAFID.GetContentClassId("ba72d9fc-6643-402c-a125-f3b08362fb75")) {

        }

        public AqlAliasConatctUs(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString FormContainer {
            get {
                return new AqlExpressionPropertyLongString(AqlConatctUs.FormContainer, this);
            }
        }

        public AqlExpressionPropertyLongString SignUp {
            get {
                return new AqlExpressionPropertyLongString(AqlConatctUs.SignUp, this);
            }
        }

    }
}
