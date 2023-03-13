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
    public partial class ControlPanel: WAF.Engine.Content.Native.HierarchicalContent {
        NodeParentPropertyValue<WAF.Engine.Content.MySite.Course> _course;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.MySite.Course> Course{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.MySite.Course>.GetPropValue(WAFID.GetDataValueId("c59769d7-0316-418f-a0ca-1db011204a76"), ref _course, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.MySite.Venue> _venue;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.MySite.Venue> Venue{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.MySite.Venue>.GetPropValue(WAFID.GetDataValueId("7a3760fc-75df-4cbb-9886-4b03d71c9127"), ref _venue, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ControlPanel>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ControlPanel>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ControlPanel>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf");
            }
        }

        public static int PropertyIdCourse {
            get {
                return WAFID.GetPropertyId("b06d0548-5c2b-48b8-adeb-7f878f0e47e6");
            }
        }

        public static int DataValueIdCourseCourse {
            get {
                return WAFID.GetDataValueId("c59769d7-0316-418f-a0ca-1db011204a76");
            }
        }

        public static int PropertyIdVenue {
            get {
                return WAFID.GetPropertyId("b2e4695c-a213-464b-bf1f-5e180bc5ca0e");
            }
        }

        public static int DataValueIdVenueVenue {
            get {
                return WAFID.GetDataValueId("7a3760fc-75df-4cbb-9886-4b03d71c9127");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("b06d0548-5c2b-48b8-adeb-7f878f0e47e6")) {
                object init = Course;
                return _course;
            }
            else if (propertyId == WAFID.GetPropertyId("b2e4695c-a213-464b-bf1f-5e180bc5ca0e")) {
                object init = Venue;
                return _venue;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _course = null;
            _venue = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlControlPanel {
        public static SqlTable Table {
            get {
                return new SqlTable("control_panel", WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldInteger Course {
                get {
                    return new SqlFieldInteger("course", Table, WAFID.GetDataValueId("c59769d7-0316-418f-a0ca-1db011204a76"));
                }
            }

            public static SqlFieldInteger Venue {
                get {
                    return new SqlFieldInteger("venue", Table, WAFID.GetDataValueId("7a3760fc-75df-4cbb-9886-4b03d71c9127"));
                }
            }

        }
    }
    public class SqlAliasControlPanel : SqlAlias {
        public SqlAliasControlPanel()
            : base(SqlControlPanel.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldInteger Course {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.Course, this);
            }
        }

        public SqlExpressionFieldInteger Venue {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.Venue, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlControlPanel{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")); 
            }
        }

        public static AqlPropertyInteger Course {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlControlPanel.Field.Course, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyInteger Venue {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlControlPanel.Field.Venue, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasControlPanel
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasControlPanel()
            : base(WAFID.GetContentClassId("e72004c3-bde2-4f70-91a0-4993d0e7eebf")) {

        }

        public AqlAliasControlPanel(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyInteger Course {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.Course, this);
            }
        }

        public AqlExpressionPropertyInteger Venue {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.Venue, this);
            }
        }

    }
}
