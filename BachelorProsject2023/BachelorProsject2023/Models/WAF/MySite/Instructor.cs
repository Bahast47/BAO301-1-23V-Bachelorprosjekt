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
    public partial class Instructor: WAF.Engine.Content.Native.HierarchicalContent {
        NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course> _courses;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course> Courses{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Course>.GetValue(WAFID.GetDataValueId("dfc967a2-0ae1-476e-b185-ba621174ad5a"), ref _courses, this);}
        }
      
        HTMLPropertyValue _description;
        public virtual string Description {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("a0f94e1f-c00b-43b9-98ce-a635b4dd45d3"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("a0f94e1f-c00b-43b9-98ce-a635b4dd45d3"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        LinkPropertyValue _linkedin;
        public virtual LinkPropertyValue Linkedin {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("f7731ecf-8703-409a-a7bc-bf18da0cd372"), ref _linkedin, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        LinkPropertyValue _instagram;
        public virtual LinkPropertyValue Instagram {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("9a16c84a-aa46-4f41-887e-0d2f37c0e208"), ref _instagram, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        LinkPropertyValue _epost;
        public virtual LinkPropertyValue Epost {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("9631e0fe-77e5-4f58-b6b3-551b6120c4f0"), ref _epost, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        IntegerPropertyValue _phoneNumber;
        public virtual int PhoneNumber {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("d7ad3861-6aef-4958-8ab4-79caa831c071"), ref _phoneNumber, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("d7ad3861-6aef-4958-8ab4-79caa831c071"), ref _phoneNumber, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        CheckBoxPropertyValue _isPublic;
        public virtual bool IsPublic {
        get { return CheckBoxPropertyValue.GetValue(WAFID.GetDataValueId("f43ce02e-f662-4131-b8b0-cde8e3396234"), ref _isPublic, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); CheckBoxPropertyValue.SetValue(WAFID.GetDataValueId("f43ce02e-f662-4131-b8b0-cde8e3396234"), ref _isPublic, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _instructorPicture;
        public virtual FilePropertyValue InstructorPicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("c96dab92-8b6e-4bf1-a940-66446875fbb0"),WAFID.GetDataValueId("07323229-bfaa-429b-922a-094ef39b866c"),WAFID.GetDataValueId("9fe90dc7-f4b2-43e4-aef5-c14a4050f65c"),WAFID.GetDataValueId("ca0bc1c9-dad9-4fa2-a785-9988ecff8d96"),WAFID.GetDataValueId("e81d9279-611d-4127-9979-21f3c5532b1f"),WAFID.GetDataValueId("e5484f57-02b8-49a4-85c8-15c47eab5f82"), ref _instructorPicture, this, WAFID.GetDataValueId("f27eb826-632c-4b83-98d9-3fbb052c3d3c")); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Instructor>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Instructor>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Instructor>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526");
            }
        }

        public static int PropertyIdCourses {
            get {
                return WAFID.GetPropertyId("dfc967a2-0ae1-476e-b185-ba621174ad5a");
            }
        }

        public static int PropertyIdDescription {
            get {
                return WAFID.GetPropertyId("7d6cd5cf-16ed-46cf-a267-dd4cf43edc0f");
            }
        }

        public static int DataValueIdDescriptionDescription {
            get {
                return WAFID.GetDataValueId("a0f94e1f-c00b-43b9-98ce-a635b4dd45d3");
            }
        }

        public static int PropertyIdLinkedin {
            get {
                return WAFID.GetPropertyId("3e4a3fd6-c861-443f-947d-0b6d73d14931");
            }
        }

        public static int DataValueIdLinkedinLinkedin {
            get {
                return WAFID.GetDataValueId("f7731ecf-8703-409a-a7bc-bf18da0cd372");
            }
        }

        public static int PropertyIdInstagram {
            get {
                return WAFID.GetPropertyId("d068c542-8298-4842-b16b-d98d79927b96");
            }
        }

        public static int DataValueIdInstagramInstagram {
            get {
                return WAFID.GetDataValueId("9a16c84a-aa46-4f41-887e-0d2f37c0e208");
            }
        }

        public static int PropertyIdEpost {
            get {
                return WAFID.GetPropertyId("e7220d11-e68d-49f6-b181-b40e0c7aa473");
            }
        }

        public static int DataValueIdEpostEpost {
            get {
                return WAFID.GetDataValueId("9631e0fe-77e5-4f58-b6b3-551b6120c4f0");
            }
        }

        public static int PropertyIdPhoneNumber {
            get {
                return WAFID.GetPropertyId("4d97f034-970e-4462-8231-801557edb941");
            }
        }

        public static int DataValueIdPhoneNumberPhoneNumber {
            get {
                return WAFID.GetDataValueId("d7ad3861-6aef-4958-8ab4-79caa831c071");
            }
        }

        public static int PropertyIdIsPublic {
            get {
                return WAFID.GetPropertyId("929a46d6-b5a0-479c-9056-55d14a02a8ac");
            }
        }

        public static int DataValueIdIsPublicIsPublic {
            get {
                return WAFID.GetDataValueId("f43ce02e-f662-4131-b8b0-cde8e3396234");
            }
        }

        public static int PropertyIdInstructorPicture {
            get {
                return WAFID.GetPropertyId("f27eb826-632c-4b83-98d9-3fbb052c3d3c");
            }
        }

        public static int DataValueIdInstructorPictureInstructorPictureFilename {
            get {
                return WAFID.GetDataValueId("07323229-bfaa-429b-922a-094ef39b866c");
            }
        }

        public static int DataValueIdInstructorPictureInstructorPictureTypeName {
            get {
                return WAFID.GetDataValueId("9fe90dc7-f4b2-43e4-aef5-c14a4050f65c");
            }
        }

        public static int DataValueIdInstructorPictureInstructorPictureExtension {
            get {
                return WAFID.GetDataValueId("ca0bc1c9-dad9-4fa2-a785-9988ecff8d96");
            }
        }

        public static int DataValueIdInstructorPictureInstructorPictureBytes {
            get {
                return WAFID.GetDataValueId("e81d9279-611d-4127-9979-21f3c5532b1f");
            }
        }

        public static int DataValueIdInstructorPictureInstructorPictureInfo {
            get {
                return WAFID.GetDataValueId("e5484f57-02b8-49a4-85c8-15c47eab5f82");
            }
        }

        public static int DataValueIdInstructorPictureInstructorPictureInt {
            get {
                return WAFID.GetDataValueId("c96dab92-8b6e-4bf1-a940-66446875fbb0");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("dfc967a2-0ae1-476e-b185-ba621174ad5a")) {
                object init = Courses;
                return _courses;
            }
            else if (propertyId == WAFID.GetPropertyId("7d6cd5cf-16ed-46cf-a267-dd4cf43edc0f")) {
                object init = Description;
                return _description;
            }
            else if (propertyId == WAFID.GetPropertyId("3e4a3fd6-c861-443f-947d-0b6d73d14931")) {
                object init = Linkedin;
                return _linkedin;
            }
            else if (propertyId == WAFID.GetPropertyId("d068c542-8298-4842-b16b-d98d79927b96")) {
                object init = Instagram;
                return _instagram;
            }
            else if (propertyId == WAFID.GetPropertyId("e7220d11-e68d-49f6-b181-b40e0c7aa473")) {
                object init = Epost;
                return _epost;
            }
            else if (propertyId == WAFID.GetPropertyId("4d97f034-970e-4462-8231-801557edb941")) {
                object init = PhoneNumber;
                return _phoneNumber;
            }
            else if (propertyId == WAFID.GetPropertyId("929a46d6-b5a0-479c-9056-55d14a02a8ac")) {
                object init = IsPublic;
                return _isPublic;
            }
            else if (propertyId == WAFID.GetPropertyId("f27eb826-632c-4b83-98d9-3fbb052c3d3c")) {
                object init = InstructorPicture;
                return _instructorPicture;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _courses = null;
            _description = null;
            _linkedin = null;
            _instagram = null;
            _epost = null;
            _phoneNumber = null;
            _isPublic = null;
            _instructorPicture = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlInstructor {
        public static SqlTable Table {
            get {
                return new SqlTable("instructor", WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString Description {
                get {
                    return new SqlFieldLongString("description", Table, WAFID.GetDataValueId("a0f94e1f-c00b-43b9-98ce-a635b4dd45d3"));
                }
            }

            public static SqlFieldShortString Linkedin {
                get {
                    return new SqlFieldShortString("linkedin", Table, WAFID.GetDataValueId("f7731ecf-8703-409a-a7bc-bf18da0cd372"));
                }
            }

            public static SqlFieldShortString Instagram {
                get {
                    return new SqlFieldShortString("instagram", Table, WAFID.GetDataValueId("9a16c84a-aa46-4f41-887e-0d2f37c0e208"));
                }
            }

            public static SqlFieldShortString Epost {
                get {
                    return new SqlFieldShortString("epost", Table, WAFID.GetDataValueId("9631e0fe-77e5-4f58-b6b3-551b6120c4f0"));
                }
            }

            public static SqlFieldInteger PhoneNumber {
                get {
                    return new SqlFieldInteger("phone_number", Table, WAFID.GetDataValueId("d7ad3861-6aef-4958-8ab4-79caa831c071"));
                }
            }

            public static SqlFieldBoolean IsPublic {
                get {
                    return new SqlFieldBoolean("is_public", Table, WAFID.GetDataValueId("f43ce02e-f662-4131-b8b0-cde8e3396234"));
                }
            }

            public static SqlFieldShortString InstructorPicture_instructor_picture_filename {
                get {
                    return new SqlFieldShortString("instructor_picture_filename", Table, WAFID.GetDataValueId("07323229-bfaa-429b-922a-094ef39b866c"));
                }
            }

            public static SqlFieldShortString InstructorPicture_instructor_picture_type_name {
                get {
                    return new SqlFieldShortString("instructor_picture_type_name", Table, WAFID.GetDataValueId("9fe90dc7-f4b2-43e4-aef5-c14a4050f65c"));
                }
            }

            public static SqlFieldShortString InstructorPicture_instructor_picture_extension {
                get {
                    return new SqlFieldShortString("instructor_picture_extension", Table, WAFID.GetDataValueId("ca0bc1c9-dad9-4fa2-a785-9988ecff8d96"));
                }
            }

            public static SqlFieldFloat InstructorPicture_instructor_picture_bytes {
                get {
                    return new SqlFieldFloat("instructor_picture_bytes", Table, WAFID.GetDataValueId("e81d9279-611d-4127-9979-21f3c5532b1f"));
                }
            }

            public static SqlFieldLongString InstructorPicture_instructor_picture_info {
                get {
                    return new SqlFieldLongString("instructor_picture_info", Table, WAFID.GetDataValueId("e5484f57-02b8-49a4-85c8-15c47eab5f82"));
                }
            }

            public static SqlFieldInteger InstructorPicture_instructor_picture_int {
                get {
                    return new SqlFieldInteger("instructor_picture_int", Table, WAFID.GetDataValueId("c96dab92-8b6e-4bf1-a940-66446875fbb0"));
                }
            }

        }
    }
    public class SqlAliasInstructor : SqlAlias {
        public SqlAliasInstructor()
            : base(SqlInstructor.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlInstructor.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString Description {
            get {
                return new SqlExpressionFieldLongString(SqlInstructor.Field.Description, this);
            }
        }

        public SqlExpressionFieldShortString Linkedin {
            get {
                return new SqlExpressionFieldShortString(SqlInstructor.Field.Linkedin, this);
            }
        }

        public SqlExpressionFieldShortString Instagram {
            get {
                return new SqlExpressionFieldShortString(SqlInstructor.Field.Instagram, this);
            }
        }

        public SqlExpressionFieldShortString Epost {
            get {
                return new SqlExpressionFieldShortString(SqlInstructor.Field.Epost, this);
            }
        }

        public SqlExpressionFieldInteger PhoneNumber {
            get {
                return new SqlExpressionFieldInteger(SqlInstructor.Field.PhoneNumber, this);
            }
        }

        public SqlExpressionFieldBoolean IsPublic {
            get {
                return new SqlExpressionFieldBoolean(SqlInstructor.Field.IsPublic, this);
            }
        }

        public SqlExpressionFieldShortString InstructorPicture_instructor_picture_filename {
            get {
                return new SqlExpressionFieldShortString(SqlInstructor.Field.InstructorPicture_instructor_picture_filename, this);
            }
        }

        public SqlExpressionFieldShortString InstructorPicture_instructor_picture_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlInstructor.Field.InstructorPicture_instructor_picture_type_name, this);
            }
        }

        public SqlExpressionFieldShortString InstructorPicture_instructor_picture_extension {
            get {
                return new SqlExpressionFieldShortString(SqlInstructor.Field.InstructorPicture_instructor_picture_extension, this);
            }
        }

        public SqlExpressionFieldFloat InstructorPicture_instructor_picture_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlInstructor.Field.InstructorPicture_instructor_picture_bytes, this);
            }
        }

        public SqlExpressionFieldLongString InstructorPicture_instructor_picture_info {
            get {
                return new SqlExpressionFieldLongString(SqlInstructor.Field.InstructorPicture_instructor_picture_info, this);
            }
        }

        public SqlExpressionFieldInteger InstructorPicture_instructor_picture_int {
            get {
                return new SqlExpressionFieldInteger(SqlInstructor.Field.InstructorPicture_instructor_picture_int, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlInstructor{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")); 
            }
        }

        public static AqlPropertyRelation Courses {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("dfc967a2-0ae1-476e-b185-ba621174ad5a"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasCourse(), new WAF.Engine.Query.MySite.AqlAliasInstructor(), WAF.Engine.Query.MySite.AqlRelCoursesIntructors.Relation));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlInstructor.Field.Description, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyShortString Linkedin {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlInstructor.Field.Linkedin, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyShortString Instagram {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlInstructor.Field.Instagram, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyShortString Epost {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlInstructor.Field.Epost, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyInteger PhoneNumber {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlInstructor.Field.PhoneNumber, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyBoolean IsPublic {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.MySite.SqlInstructor.Field.IsPublic, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyShortString InstructorPicture_instructor_picture_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlInstructor.Field.InstructorPicture_instructor_picture_filename, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyShortString InstructorPicture_instructor_picture_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlInstructor.Field.InstructorPicture_instructor_picture_type_name, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyShortString InstructorPicture_instructor_picture_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlInstructor.Field.InstructorPicture_instructor_picture_extension, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyFloat InstructorPicture_instructor_picture_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.MySite.SqlInstructor.Field.InstructorPicture_instructor_picture_bytes, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyLongString InstructorPicture_instructor_picture_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlInstructor.Field.InstructorPicture_instructor_picture_info, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyInteger InstructorPicture_instructor_picture_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlInstructor.Field.InstructorPicture_instructor_picture_int, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasInstructor
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasInstructor()
            : base(WAFID.GetContentClassId("1429c01d-9448-47a1-a435-3752f4231526")) {

        }

        public AqlAliasInstructor(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString Description {
            get {
                return new AqlExpressionPropertyLongString(AqlInstructor.Description, this);
            }
        }

        public AqlExpressionPropertyShortString Linkedin {
            get {
                return new AqlExpressionPropertyShortString(AqlInstructor.Linkedin, this);
            }
        }

        public AqlExpressionPropertyShortString Instagram {
            get {
                return new AqlExpressionPropertyShortString(AqlInstructor.Instagram, this);
            }
        }

        public AqlExpressionPropertyShortString Epost {
            get {
                return new AqlExpressionPropertyShortString(AqlInstructor.Epost, this);
            }
        }

        public AqlExpressionPropertyInteger PhoneNumber {
            get {
                return new AqlExpressionPropertyInteger(AqlInstructor.PhoneNumber, this);
            }
        }

        public AqlExpressionPropertyBoolean IsPublic {
            get {
                return new AqlExpressionPropertyBoolean(AqlInstructor.IsPublic, this);
            }
        }

        public AqlExpressionPropertyShortString InstructorPicture_instructor_picture_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlInstructor.InstructorPicture_instructor_picture_filename, this);
            }
        }

        public AqlExpressionPropertyShortString InstructorPicture_instructor_picture_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlInstructor.InstructorPicture_instructor_picture_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString InstructorPicture_instructor_picture_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlInstructor.InstructorPicture_instructor_picture_extension, this);
            }
        }

        public AqlExpressionPropertyFloat InstructorPicture_instructor_picture_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlInstructor.InstructorPicture_instructor_picture_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString InstructorPicture_instructor_picture_info {
            get {
                return new AqlExpressionPropertyLongString(AqlInstructor.InstructorPicture_instructor_picture_info, this);
            }
        }

        public AqlExpressionPropertyInteger InstructorPicture_instructor_picture_int {
            get {
                return new AqlExpressionPropertyInteger(AqlInstructor.InstructorPicture_instructor_picture_int, this);
            }
        }

    }
}
