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
    public partial class Venue: WAF.Engine.Content.Native.HierarchicalContent {
        LinkPropertyValue _mapsLink;
        public virtual LinkPropertyValue MapsLink {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("367e3bcd-bd81-4fbd-8b18-7496d85b65d8"), ref _mapsLink, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        HTMLPropertyValue _adress;
        public virtual string Adress {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("ea739f7e-2f9e-46fa-b172-b800c3ef146a"), ref _adress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("ea739f7e-2f9e-46fa-b172-b800c3ef146a"), ref _adress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        LinkPropertyValue _homeSite;
        public virtual LinkPropertyValue HomeSite {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("eb8c0daf-1310-4778-b39a-e9867ef2aa4c"), ref _homeSite, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        FilePropertyValue _venuePicture;
        public virtual FilePropertyValue VenuePicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("9a3c1164-0bd5-4d8f-a51c-9fb798c72338"),WAFID.GetDataValueId("bfa998ef-832e-4856-8278-d4aebeeb2785"),WAFID.GetDataValueId("4f874681-58ee-4f6b-8bc9-f10c70b1acab"),WAFID.GetDataValueId("63db7f29-968d-4e85-9e92-2026abb57ff3"),WAFID.GetDataValueId("524f4f32-4a8e-4b7b-8695-50177b27b3a5"),WAFID.GetDataValueId("8c78aecd-efac-4ae3-a5bc-fc7f65fc5ccb"), ref _venuePicture, this, WAFID.GetDataValueId("c5dd1a62-b082-4bf5-aca6-ec2634ea067d")); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Venue>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Venue>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Venue>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387");
            }
        }

        public static int PropertyIdMapsLink {
            get {
                return WAFID.GetPropertyId("1aa28122-2253-42f1-bad1-ddf57b44cb36");
            }
        }

        public static int DataValueIdMapsLinkMapsLink {
            get {
                return WAFID.GetDataValueId("367e3bcd-bd81-4fbd-8b18-7496d85b65d8");
            }
        }

        public static int PropertyIdAdress {
            get {
                return WAFID.GetPropertyId("fd1ce14d-a6e2-4902-bb91-514d1a39e6ac");
            }
        }

        public static int DataValueIdAdressAdress {
            get {
                return WAFID.GetDataValueId("ea739f7e-2f9e-46fa-b172-b800c3ef146a");
            }
        }

        public static int PropertyIdHomeSite {
            get {
                return WAFID.GetPropertyId("4d04ed51-8d6e-4c63-98e4-c90b1ffddf73");
            }
        }

        public static int DataValueIdHomeSiteHomeSite {
            get {
                return WAFID.GetDataValueId("eb8c0daf-1310-4778-b39a-e9867ef2aa4c");
            }
        }

        public static int PropertyIdVenuePicture {
            get {
                return WAFID.GetPropertyId("c5dd1a62-b082-4bf5-aca6-ec2634ea067d");
            }
        }

        public static int DataValueIdVenuePictureVenuePictureFilename {
            get {
                return WAFID.GetDataValueId("bfa998ef-832e-4856-8278-d4aebeeb2785");
            }
        }

        public static int DataValueIdVenuePictureVenuePictureTypeName {
            get {
                return WAFID.GetDataValueId("4f874681-58ee-4f6b-8bc9-f10c70b1acab");
            }
        }

        public static int DataValueIdVenuePictureVenuePictureExtension {
            get {
                return WAFID.GetDataValueId("63db7f29-968d-4e85-9e92-2026abb57ff3");
            }
        }

        public static int DataValueIdVenuePictureVenuePictureBytes {
            get {
                return WAFID.GetDataValueId("524f4f32-4a8e-4b7b-8695-50177b27b3a5");
            }
        }

        public static int DataValueIdVenuePictureVenuePictureInfo {
            get {
                return WAFID.GetDataValueId("8c78aecd-efac-4ae3-a5bc-fc7f65fc5ccb");
            }
        }

        public static int DataValueIdVenuePictureVenuePictureInt {
            get {
                return WAFID.GetDataValueId("9a3c1164-0bd5-4d8f-a51c-9fb798c72338");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("1aa28122-2253-42f1-bad1-ddf57b44cb36")) {
                object init = MapsLink;
                return _mapsLink;
            }
            else if (propertyId == WAFID.GetPropertyId("fd1ce14d-a6e2-4902-bb91-514d1a39e6ac")) {
                object init = Adress;
                return _adress;
            }
            else if (propertyId == WAFID.GetPropertyId("4d04ed51-8d6e-4c63-98e4-c90b1ffddf73")) {
                object init = HomeSite;
                return _homeSite;
            }
            else if (propertyId == WAFID.GetPropertyId("c5dd1a62-b082-4bf5-aca6-ec2634ea067d")) {
                object init = VenuePicture;
                return _venuePicture;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _mapsLink = null;
            _adress = null;
            _homeSite = null;
            _venuePicture = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlVenue {
        public static SqlTable Table {
            get {
                return new SqlTable("venue", WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString MapsLink {
                get {
                    return new SqlFieldShortString("maps_link", Table, WAFID.GetDataValueId("367e3bcd-bd81-4fbd-8b18-7496d85b65d8"));
                }
            }

            public static SqlFieldLongString Adress {
                get {
                    return new SqlFieldLongString("adress", Table, WAFID.GetDataValueId("ea739f7e-2f9e-46fa-b172-b800c3ef146a"));
                }
            }

            public static SqlFieldShortString HomeSite {
                get {
                    return new SqlFieldShortString("home_site", Table, WAFID.GetDataValueId("eb8c0daf-1310-4778-b39a-e9867ef2aa4c"));
                }
            }

            public static SqlFieldShortString VenuePicture_venue_picture_filename {
                get {
                    return new SqlFieldShortString("venue_picture_filename", Table, WAFID.GetDataValueId("bfa998ef-832e-4856-8278-d4aebeeb2785"));
                }
            }

            public static SqlFieldShortString VenuePicture_venue_picture_type_name {
                get {
                    return new SqlFieldShortString("venue_picture_type_name", Table, WAFID.GetDataValueId("4f874681-58ee-4f6b-8bc9-f10c70b1acab"));
                }
            }

            public static SqlFieldShortString VenuePicture_venue_picture_extension {
                get {
                    return new SqlFieldShortString("venue_picture_extension", Table, WAFID.GetDataValueId("63db7f29-968d-4e85-9e92-2026abb57ff3"));
                }
            }

            public static SqlFieldFloat VenuePicture_venue_picture_bytes {
                get {
                    return new SqlFieldFloat("venue_picture_bytes", Table, WAFID.GetDataValueId("524f4f32-4a8e-4b7b-8695-50177b27b3a5"));
                }
            }

            public static SqlFieldLongString VenuePicture_venue_picture_info {
                get {
                    return new SqlFieldLongString("venue_picture_info", Table, WAFID.GetDataValueId("8c78aecd-efac-4ae3-a5bc-fc7f65fc5ccb"));
                }
            }

            public static SqlFieldInteger VenuePicture_venue_picture_int {
                get {
                    return new SqlFieldInteger("venue_picture_int", Table, WAFID.GetDataValueId("9a3c1164-0bd5-4d8f-a51c-9fb798c72338"));
                }
            }

        }
    }
    public class SqlAliasVenue : SqlAlias {
        public SqlAliasVenue()
            : base(SqlVenue.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlVenue.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString MapsLink {
            get {
                return new SqlExpressionFieldShortString(SqlVenue.Field.MapsLink, this);
            }
        }

        public SqlExpressionFieldLongString Adress {
            get {
                return new SqlExpressionFieldLongString(SqlVenue.Field.Adress, this);
            }
        }

        public SqlExpressionFieldShortString HomeSite {
            get {
                return new SqlExpressionFieldShortString(SqlVenue.Field.HomeSite, this);
            }
        }

        public SqlExpressionFieldShortString VenuePicture_venue_picture_filename {
            get {
                return new SqlExpressionFieldShortString(SqlVenue.Field.VenuePicture_venue_picture_filename, this);
            }
        }

        public SqlExpressionFieldShortString VenuePicture_venue_picture_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlVenue.Field.VenuePicture_venue_picture_type_name, this);
            }
        }

        public SqlExpressionFieldShortString VenuePicture_venue_picture_extension {
            get {
                return new SqlExpressionFieldShortString(SqlVenue.Field.VenuePicture_venue_picture_extension, this);
            }
        }

        public SqlExpressionFieldFloat VenuePicture_venue_picture_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlVenue.Field.VenuePicture_venue_picture_bytes, this);
            }
        }

        public SqlExpressionFieldLongString VenuePicture_venue_picture_info {
            get {
                return new SqlExpressionFieldLongString(SqlVenue.Field.VenuePicture_venue_picture_info, this);
            }
        }

        public SqlExpressionFieldInteger VenuePicture_venue_picture_int {
            get {
                return new SqlExpressionFieldInteger(SqlVenue.Field.VenuePicture_venue_picture_int, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlVenue{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")); 
            }
        }

        public static AqlPropertyShortString MapsLink {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlVenue.Field.MapsLink, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyLongString Adress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlVenue.Field.Adress, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyShortString HomeSite {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlVenue.Field.HomeSite, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyShortString VenuePicture_venue_picture_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlVenue.Field.VenuePicture_venue_picture_filename, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyShortString VenuePicture_venue_picture_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlVenue.Field.VenuePicture_venue_picture_type_name, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyShortString VenuePicture_venue_picture_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlVenue.Field.VenuePicture_venue_picture_extension, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyFloat VenuePicture_venue_picture_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.MySite.SqlVenue.Field.VenuePicture_venue_picture_bytes, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyLongString VenuePicture_venue_picture_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlVenue.Field.VenuePicture_venue_picture_info, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyInteger VenuePicture_venue_picture_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlVenue.Field.VenuePicture_venue_picture_int, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasVenue
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasVenue()
            : base(WAFID.GetContentClassId("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")) {

        }

        public AqlAliasVenue(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString MapsLink {
            get {
                return new AqlExpressionPropertyShortString(AqlVenue.MapsLink, this);
            }
        }

        public AqlExpressionPropertyLongString Adress {
            get {
                return new AqlExpressionPropertyLongString(AqlVenue.Adress, this);
            }
        }

        public AqlExpressionPropertyShortString HomeSite {
            get {
                return new AqlExpressionPropertyShortString(AqlVenue.HomeSite, this);
            }
        }

        public AqlExpressionPropertyShortString VenuePicture_venue_picture_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlVenue.VenuePicture_venue_picture_filename, this);
            }
        }

        public AqlExpressionPropertyShortString VenuePicture_venue_picture_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlVenue.VenuePicture_venue_picture_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString VenuePicture_venue_picture_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlVenue.VenuePicture_venue_picture_extension, this);
            }
        }

        public AqlExpressionPropertyFloat VenuePicture_venue_picture_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlVenue.VenuePicture_venue_picture_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString VenuePicture_venue_picture_info {
            get {
                return new AqlExpressionPropertyLongString(AqlVenue.VenuePicture_venue_picture_info, this);
            }
        }

        public AqlExpressionPropertyInteger VenuePicture_venue_picture_int {
            get {
                return new AqlExpressionPropertyInteger(AqlVenue.VenuePicture_venue_picture_int, this);
            }
        }

    }
}
