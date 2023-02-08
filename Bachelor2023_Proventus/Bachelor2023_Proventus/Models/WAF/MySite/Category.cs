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
    public partial class Category: WAF.Engine.Content.Native.HierarchicalContent {
        NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course> _courses;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course> Courses{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course>.GetValue(WAFID.GetDataValueId("7ce24a13-17d8-47a6-865c-cfa0832d0b6b"), ref _courses, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Category>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Category>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Category>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1");
            }
        }

        public static int PropertyIdCourses {
            get {
                return WAFID.GetPropertyId("7ce24a13-17d8-47a6-865c-cfa0832d0b6b");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("7ce24a13-17d8-47a6-865c-cfa0832d0b6b")) {
                object init = Courses;
                return _courses;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _courses = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlCategory {
        public static SqlTable Table {
            get {
                return new SqlTable("category", WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

        }
    }
    public class SqlAliasCategory : SqlAlias {
        public SqlAliasCategory()
            : base(SqlCategory.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlCategory.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlCategory{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")); 
            }
        }

        public static AqlPropertyRelation Courses {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("7ce24a13-17d8-47a6-865c-cfa0832d0b6b"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasCourse(), new WAF.Engine.Query.MySite.AqlAliasCategory(), WAF.Engine.Query.MySite.AqlRelCoursesCategories.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasCategory
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasCategory()
            : base(WAFID.GetContentClassId("94ce9a05-e7cd-426f-821f-967264ab6ed1")) {

        }

        public AqlAliasCategory(int contentClassId)
            : base(contentClassId) {

        }

    }
}
