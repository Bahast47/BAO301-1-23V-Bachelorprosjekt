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
    public partial class Participant: WAF.Engine.Content.Native.SystemUser {
        NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course> _courses;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course> Courses{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course>.GetValue(WAFID.GetDataValueId("4bc57171-1e3c-4534-ba59-e28164ee259f"), ref _courses, this);}
        }
      
        HTMLPropertyValue _allergies;
        public virtual string Allergies {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("4fc7b5f4-05ca-4ca4-9a41-aa39e2b8d3be"), ref _allergies, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("4fc7b5f4-05ca-4ca4-9a41-aa39e2b8d3be"), ref _allergies, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Participant>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Participant>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Participant>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a");
            }
        }

        public static int PropertyIdCourses {
            get {
                return WAFID.GetPropertyId("4bc57171-1e3c-4534-ba59-e28164ee259f");
            }
        }

        public static int PropertyIdAllergies {
            get {
                return WAFID.GetPropertyId("1975cc28-d702-4bec-b504-d4aaa5377fff");
            }
        }

        public static int DataValueIdAllergiesAllergies {
            get {
                return WAFID.GetDataValueId("4fc7b5f4-05ca-4ca4-9a41-aa39e2b8d3be");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("4bc57171-1e3c-4534-ba59-e28164ee259f")) {
                object init = Courses;
                return _courses;
            }
            else if (propertyId == WAFID.GetPropertyId("1975cc28-d702-4bec-b504-d4aaa5377fff")) {
                object init = Allergies;
                return _allergies;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _courses = null;
            _allergies = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlParticipant {
        public static SqlTable Table {
            get {
                return new SqlTable("participant", WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString Allergies {
                get {
                    return new SqlFieldLongString("allergies", Table, WAFID.GetDataValueId("4fc7b5f4-05ca-4ca4-9a41-aa39e2b8d3be"));
                }
            }

        }
    }
    public class SqlAliasParticipant : SqlAlias {
        public SqlAliasParticipant()
            : base(SqlParticipant.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlParticipant.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString Allergies {
            get {
                return new SqlExpressionFieldLongString(SqlParticipant.Field.Allergies, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlParticipant{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")); 
            }
        }

        public static AqlPropertyRelation Courses {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("4bc57171-1e3c-4534-ba59-e28164ee259f"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasCourse(), new WAF.Engine.Query.MySite.AqlAliasParticipant(), WAF.Engine.Query.MySite.AqlRelCoursesParticipants.Relation));
            }
        }

        public static AqlPropertyLongString Allergies {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlParticipant.Field.Allergies, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString UserName {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.UserName, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Password {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Password, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean IsAdmin {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsAdmin, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean AllowEditLogin {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.AllowEditLogin, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyRelation DirectMemberships {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("6facd1bc-df8e-4d9c-ab2e-4614e26834e6"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasUserGroup(), new WAF.Engine.Query.Native.AqlAliasSystemUser(), WAF.Engine.Query.Native.AqlRelUserGroup.Relation));
            }
        }

        public static AqlPropertyShortString Forename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Forename, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Surname {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Surname, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Email {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Email, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger Gender {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.Gender, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyDateTime Birth {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.Birth, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Company {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Company, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString JobTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.JobTitle, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Street {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Street, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString PostZipCode {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.PostZipCode, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString ProvinceState {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.ProvinceState, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString City {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.City, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Country {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Country, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Mobile {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Mobile, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Phone {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Phone, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString IM {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.IM, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Website {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Website, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Photo_photo_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_filename, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Photo_photo_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_type_name, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString Photo_photo_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_extension, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyFloat Photo_photo_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_bytes, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString Photo_photo_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_info, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger Photo_photo_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_reference, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString Signature {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Signature, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString Comment {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Comment, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger StartSite {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.StartSite, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger PreferredLanguage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.PreferredLanguage, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean IsApproved {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsApproved, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean IsLocked {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsLocked, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger FailedLogins {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.FailedLogins, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString PasswordAnswer {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.PasswordAnswer, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString PasswordQuestion {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.PasswordQuestion, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyDateTime LastPasswordChangedDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastPasswordChangedDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyDateTime LastLoginDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastLoginDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyDateTime LastActivityDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastActivityDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyDateTime LastLockoutDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastLockoutDate, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString GUID {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.GUID, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyRelation Orders {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("42822b2c-241c-4879-a8bd-360aee78e58f"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasSystemUser(), new WAF.Engine.Query.Native.AqlAliasOrder(), WAF.Engine.Query.Native.AqlRelCustomerOrders.Relation));
            }
        }

        public static AqlPropertyInteger PreferredUILanguage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.PreferredUILanguage, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString RestrictLoginsByIPs {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.RestrictLoginsByIPs, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString VisitorId {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.VisitorId, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString UIConfig {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.UIConfig, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString TwoFactorPersistentKeys {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.TwoFactorPersistentKeys, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasParticipant
        : WAF.Engine.Query.Native.AqlAliasSystemUser{

        public AqlAliasParticipant()
            : base(WAFID.GetContentClassId("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")) {

        }

        public AqlAliasParticipant(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString Allergies {
            get {
                return new AqlExpressionPropertyLongString(AqlParticipant.Allergies, this);
            }
        }

    }
}
