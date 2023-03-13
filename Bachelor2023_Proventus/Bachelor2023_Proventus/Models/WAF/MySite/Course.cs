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
    public partial class Course: WAF.Engine.Content.Native.HierarchicalContent {
        DateTimePropertyValue _start;
        public virtual DateTime Start {
        get { return DateTimePropertyValue.GetValue(WAFID.GetDataValueId("e03a0057-dd22-40fd-b014-6784467f4329"), ref _start, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); DateTimePropertyValue.SetValue(WAFID.GetDataValueId("e03a0057-dd22-40fd-b014-6784467f4329"), ref _start, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        DateTimePropertyValue _end;
        public virtual DateTime End {
        get { return DateTimePropertyValue.GetValue(WAFID.GetDataValueId("175a81fc-4c98-4809-8ca7-0ccc71620f93"), ref _end, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); DateTimePropertyValue.SetValue(WAFID.GetDataValueId("175a81fc-4c98-4809-8ca7-0ccc71620f93"), ref _end, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _description;
        public virtual string Description {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("ee159d07-48d5-4922-a7c2-e6767ee4e468"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("ee159d07-48d5-4922-a7c2-e6767ee4e468"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        IntegerPropertyValue _price;
        public virtual int Price {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("b76b1126-cb28-440f-8808-8766bb70a3a8"), ref _price, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("b76b1126-cb28-440f-8808-8766bb70a3a8"), ref _price, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        IntegerPropertyValue _numberOfSeats;
        public virtual int NumberOfSeats {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("e78ed501-8cfb-4ce8-8040-6dee0731f920"), ref _numberOfSeats, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("e78ed501-8cfb-4ce8-8040-6dee0731f920"), ref _numberOfSeats, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        CheckBoxPropertyValue _isFree;
        public virtual bool IsFree {
        get { return CheckBoxPropertyValue.GetValue(WAFID.GetDataValueId("55437c8f-59e5-440f-93b8-0f929783b422"), ref _isFree, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); CheckBoxPropertyValue.SetValue(WAFID.GetDataValueId("55437c8f-59e5-440f-93b8-0f929783b422"), ref _isFree, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        CheckBoxPropertyValue _isFull;
        public virtual bool IsFull {
        get { return CheckBoxPropertyValue.GetValue(WAFID.GetDataValueId("97af5c32-73c1-41bf-adf6-74e14ec2e6b7"), ref _isFull, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); CheckBoxPropertyValue.SetValue(WAFID.GetDataValueId("97af5c32-73c1-41bf-adf6-74e14ec2e6b7"), ref _isFull, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Instructor> _instructors;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Instructor> Instructors{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Instructor>.GetValue(WAFID.GetDataValueId("063fed50-4853-4d86-8d8d-dcb54d144e8b"), ref _instructors, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Participant> _participants;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Participant> Participants{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Participant>.GetValue(WAFID.GetDataValueId("56204a02-f18d-46b0-a393-2207c1b504c7"), ref _participants, this);}
        }
      
        DateTimePropertyValue _registrationDeadLine;
        public virtual DateTime RegistrationDeadLine {
        get { return DateTimePropertyValue.GetValue(WAFID.GetDataValueId("f72fe306-2fe3-4ca2-b4cf-2b3224618a47"), ref _registrationDeadLine, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); DateTimePropertyValue.SetValue(WAFID.GetDataValueId("f72fe306-2fe3-4ca2-b4cf-2b3224618a47"), ref _registrationDeadLine, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Category> _categories;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Category> Categories{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Category>.GetValue(WAFID.GetDataValueId("aa60882a-94a9-4bba-b05a-0909b043b6b2"), ref _categories, this);}
        }
      
        FilePropertyValue _coursePicture;
        public virtual FilePropertyValue CoursePicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("66799074-6a52-449a-a696-889d9bf132df"),WAFID.GetDataValueId("85b2e2bd-7609-4047-a0df-eb0947c626a2"),WAFID.GetDataValueId("bb5b41af-d7e8-433f-aa57-7dd43674283d"),WAFID.GetDataValueId("60d66ff3-e993-4caf-8dec-f04bbaf4a666"),WAFID.GetDataValueId("049c8ba3-1e13-4edc-b59f-f5e48d3f1b29"),WAFID.GetDataValueId("96f89c2c-ed8b-477f-9bb5-9891419db24b"), ref _coursePicture, this, WAFID.GetDataValueId("07d321db-3b0d-41c6-bcb3-5cdc0088b9c9")); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Venue> _venues;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Venue> Venues{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.MySite.Venue>.GetValue(WAFID.GetDataValueId("b531a89f-4b7a-400f-ad2b-4b0daf5ea3f9"), ref _venues, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.MySite.RegistrationForms> _registrationForms;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.MySite.RegistrationForms> RegistrationForms{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.MySite.RegistrationForms>.GetValue(WAFID.GetDataValueId("43c8b7de-6709-4da5-a68d-7981f06b64cd"), ref _registrationForms, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Course>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Course>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Course>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5");
            }
        }

        public static int PropertyIdStart {
            get {
                return WAFID.GetPropertyId("f18db84f-6f95-4769-ac35-3e441378faa0");
            }
        }

        public static int DataValueIdStartStart {
            get {
                return WAFID.GetDataValueId("e03a0057-dd22-40fd-b014-6784467f4329");
            }
        }

        public static int PropertyIdEnd {
            get {
                return WAFID.GetPropertyId("2d42b3bd-d02e-4f66-aa34-79f983405cbc");
            }
        }

        public static int DataValueIdEndEnd {
            get {
                return WAFID.GetDataValueId("175a81fc-4c98-4809-8ca7-0ccc71620f93");
            }
        }

        public static int PropertyIdDescription {
            get {
                return WAFID.GetPropertyId("1215da0f-60c3-487b-8d1a-a54f8cd1fb73");
            }
        }

        public static int DataValueIdDescriptionDescription {
            get {
                return WAFID.GetDataValueId("ee159d07-48d5-4922-a7c2-e6767ee4e468");
            }
        }

        public static int PropertyIdPrice {
            get {
                return WAFID.GetPropertyId("2236e349-c510-4e77-9ac5-df1267d03327");
            }
        }

        public static int DataValueIdPricePrice {
            get {
                return WAFID.GetDataValueId("b76b1126-cb28-440f-8808-8766bb70a3a8");
            }
        }

        public static int PropertyIdNumberOfSeats {
            get {
                return WAFID.GetPropertyId("ebce4c2c-87cc-4d2e-830c-da015db14df5");
            }
        }

        public static int DataValueIdNumberOfSeatsNumberOfSeats {
            get {
                return WAFID.GetDataValueId("e78ed501-8cfb-4ce8-8040-6dee0731f920");
            }
        }

        public static int PropertyIdIsFree {
            get {
                return WAFID.GetPropertyId("37b35cbd-b7d3-4322-ac2a-05e84ec8cdfd");
            }
        }

        public static int DataValueIdIsFreeIsFree {
            get {
                return WAFID.GetDataValueId("55437c8f-59e5-440f-93b8-0f929783b422");
            }
        }

        public static int PropertyIdIsFull {
            get {
                return WAFID.GetPropertyId("bb5aebc1-d4e2-4b02-82d2-caf0fb7803c5");
            }
        }

        public static int DataValueIdIsFullIsFull {
            get {
                return WAFID.GetDataValueId("97af5c32-73c1-41bf-adf6-74e14ec2e6b7");
            }
        }

        public static int PropertyIdInstructors {
            get {
                return WAFID.GetPropertyId("063fed50-4853-4d86-8d8d-dcb54d144e8b");
            }
        }

        public static int PropertyIdParticipants {
            get {
                return WAFID.GetPropertyId("56204a02-f18d-46b0-a393-2207c1b504c7");
            }
        }

        public static int PropertyIdRegistrationDeadLine {
            get {
                return WAFID.GetPropertyId("952a4b9e-481b-4e24-ac7f-3d8e7e406ff2");
            }
        }

        public static int DataValueIdRegistrationDeadLineRegistrationDeadLine {
            get {
                return WAFID.GetDataValueId("f72fe306-2fe3-4ca2-b4cf-2b3224618a47");
            }
        }

        public static int PropertyIdCategories {
            get {
                return WAFID.GetPropertyId("aa60882a-94a9-4bba-b05a-0909b043b6b2");
            }
        }

        public static int PropertyIdCoursePicture {
            get {
                return WAFID.GetPropertyId("07d321db-3b0d-41c6-bcb3-5cdc0088b9c9");
            }
        }

        public static int DataValueIdCoursePictureCoursePictureFilename {
            get {
                return WAFID.GetDataValueId("85b2e2bd-7609-4047-a0df-eb0947c626a2");
            }
        }

        public static int DataValueIdCoursePictureCoursePictureTypeName {
            get {
                return WAFID.GetDataValueId("bb5b41af-d7e8-433f-aa57-7dd43674283d");
            }
        }

        public static int DataValueIdCoursePictureCoursePictureExtension {
            get {
                return WAFID.GetDataValueId("60d66ff3-e993-4caf-8dec-f04bbaf4a666");
            }
        }

        public static int DataValueIdCoursePictureCoursePictureBytes {
            get {
                return WAFID.GetDataValueId("049c8ba3-1e13-4edc-b59f-f5e48d3f1b29");
            }
        }

        public static int DataValueIdCoursePictureCoursePictureInfo {
            get {
                return WAFID.GetDataValueId("96f89c2c-ed8b-477f-9bb5-9891419db24b");
            }
        }

        public static int DataValueIdCoursePictureCoursePictureInt {
            get {
                return WAFID.GetDataValueId("66799074-6a52-449a-a696-889d9bf132df");
            }
        }

        public static int PropertyIdVenues {
            get {
                return WAFID.GetPropertyId("b531a89f-4b7a-400f-ad2b-4b0daf5ea3f9");
            }
        }

        public static int PropertyIdRegistrationForms {
            get {
                return WAFID.GetPropertyId("43c8b7de-6709-4da5-a68d-7981f06b64cd");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("f18db84f-6f95-4769-ac35-3e441378faa0")) {
                object init = Start;
                return _start;
            }
            else if (propertyId == WAFID.GetPropertyId("2d42b3bd-d02e-4f66-aa34-79f983405cbc")) {
                object init = End;
                return _end;
            }
            else if (propertyId == WAFID.GetPropertyId("1215da0f-60c3-487b-8d1a-a54f8cd1fb73")) {
                object init = Description;
                return _description;
            }
            else if (propertyId == WAFID.GetPropertyId("2236e349-c510-4e77-9ac5-df1267d03327")) {
                object init = Price;
                return _price;
            }
            else if (propertyId == WAFID.GetPropertyId("ebce4c2c-87cc-4d2e-830c-da015db14df5")) {
                object init = NumberOfSeats;
                return _numberOfSeats;
            }
            else if (propertyId == WAFID.GetPropertyId("37b35cbd-b7d3-4322-ac2a-05e84ec8cdfd")) {
                object init = IsFree;
                return _isFree;
            }
            else if (propertyId == WAFID.GetPropertyId("bb5aebc1-d4e2-4b02-82d2-caf0fb7803c5")) {
                object init = IsFull;
                return _isFull;
            }
            else if (propertyId == WAFID.GetPropertyId("063fed50-4853-4d86-8d8d-dcb54d144e8b")) {
                object init = Instructors;
                return _instructors;
            }
            else if (propertyId == WAFID.GetPropertyId("56204a02-f18d-46b0-a393-2207c1b504c7")) {
                object init = Participants;
                return _participants;
            }
            else if (propertyId == WAFID.GetPropertyId("952a4b9e-481b-4e24-ac7f-3d8e7e406ff2")) {
                object init = RegistrationDeadLine;
                return _registrationDeadLine;
            }
            else if (propertyId == WAFID.GetPropertyId("aa60882a-94a9-4bba-b05a-0909b043b6b2")) {
                object init = Categories;
                return _categories;
            }
            else if (propertyId == WAFID.GetPropertyId("07d321db-3b0d-41c6-bcb3-5cdc0088b9c9")) {
                object init = CoursePicture;
                return _coursePicture;
            }
            else if (propertyId == WAFID.GetPropertyId("b531a89f-4b7a-400f-ad2b-4b0daf5ea3f9")) {
                object init = Venues;
                return _venues;
            }
            else if (propertyId == WAFID.GetPropertyId("43c8b7de-6709-4da5-a68d-7981f06b64cd")) {
                object init = RegistrationForms;
                return _registrationForms;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _start = null;
            _end = null;
            _description = null;
            _price = null;
            _numberOfSeats = null;
            _isFree = null;
            _isFull = null;
            _instructors = null;
            _participants = null;
            _registrationDeadLine = null;
            _categories = null;
            _coursePicture = null;
            _venues = null;
            _registrationForms = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.MySite {
    public abstract class SqlCourse {
        public static SqlTable Table {
            get {
                return new SqlTable("course", WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldDateTime Start {
                get {
                    return new SqlFieldDateTime("start", Table, WAFID.GetDataValueId("e03a0057-dd22-40fd-b014-6784467f4329"));
                }
            }

            public static SqlFieldDateTime End {
                get {
                    return new SqlFieldDateTime("end", Table, WAFID.GetDataValueId("175a81fc-4c98-4809-8ca7-0ccc71620f93"));
                }
            }

            public static SqlFieldLongString Description {
                get {
                    return new SqlFieldLongString("description", Table, WAFID.GetDataValueId("ee159d07-48d5-4922-a7c2-e6767ee4e468"));
                }
            }

            public static SqlFieldInteger Price {
                get {
                    return new SqlFieldInteger("price", Table, WAFID.GetDataValueId("b76b1126-cb28-440f-8808-8766bb70a3a8"));
                }
            }

            public static SqlFieldInteger NumberOfSeats {
                get {
                    return new SqlFieldInteger("number_of_seats", Table, WAFID.GetDataValueId("e78ed501-8cfb-4ce8-8040-6dee0731f920"));
                }
            }

            public static SqlFieldBoolean IsFree {
                get {
                    return new SqlFieldBoolean("is_free", Table, WAFID.GetDataValueId("55437c8f-59e5-440f-93b8-0f929783b422"));
                }
            }

            public static SqlFieldBoolean IsFull {
                get {
                    return new SqlFieldBoolean("is_full", Table, WAFID.GetDataValueId("97af5c32-73c1-41bf-adf6-74e14ec2e6b7"));
                }
            }

            public static SqlFieldDateTime RegistrationDeadLine {
                get {
                    return new SqlFieldDateTime("registration_dead_line", Table, WAFID.GetDataValueId("f72fe306-2fe3-4ca2-b4cf-2b3224618a47"));
                }
            }

            public static SqlFieldShortString CoursePicture_course_picture_filename {
                get {
                    return new SqlFieldShortString("course_picture_filename", Table, WAFID.GetDataValueId("85b2e2bd-7609-4047-a0df-eb0947c626a2"));
                }
            }

            public static SqlFieldShortString CoursePicture_course_picture_type_name {
                get {
                    return new SqlFieldShortString("course_picture_type_name", Table, WAFID.GetDataValueId("bb5b41af-d7e8-433f-aa57-7dd43674283d"));
                }
            }

            public static SqlFieldShortString CoursePicture_course_picture_extension {
                get {
                    return new SqlFieldShortString("course_picture_extension", Table, WAFID.GetDataValueId("60d66ff3-e993-4caf-8dec-f04bbaf4a666"));
                }
            }

            public static SqlFieldFloat CoursePicture_course_picture_bytes {
                get {
                    return new SqlFieldFloat("course_picture_bytes", Table, WAFID.GetDataValueId("049c8ba3-1e13-4edc-b59f-f5e48d3f1b29"));
                }
            }

            public static SqlFieldLongString CoursePicture_course_picture_info {
                get {
                    return new SqlFieldLongString("course_picture_info", Table, WAFID.GetDataValueId("96f89c2c-ed8b-477f-9bb5-9891419db24b"));
                }
            }

            public static SqlFieldInteger CoursePicture_course_picture_int {
                get {
                    return new SqlFieldInteger("course_picture_int", Table, WAFID.GetDataValueId("66799074-6a52-449a-a696-889d9bf132df"));
                }
            }

        }
    }
    public class SqlAliasCourse : SqlAlias {
        public SqlAliasCourse()
            : base(SqlCourse.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlCourse.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldDateTime Start {
            get {
                return new SqlExpressionFieldDateTime(SqlCourse.Field.Start, this);
            }
        }

        public SqlExpressionFieldDateTime End {
            get {
                return new SqlExpressionFieldDateTime(SqlCourse.Field.End, this);
            }
        }

        public SqlExpressionFieldLongString Description {
            get {
                return new SqlExpressionFieldLongString(SqlCourse.Field.Description, this);
            }
        }

        public SqlExpressionFieldInteger Price {
            get {
                return new SqlExpressionFieldInteger(SqlCourse.Field.Price, this);
            }
        }

        public SqlExpressionFieldInteger NumberOfSeats {
            get {
                return new SqlExpressionFieldInteger(SqlCourse.Field.NumberOfSeats, this);
            }
        }

        public SqlExpressionFieldBoolean IsFree {
            get {
                return new SqlExpressionFieldBoolean(SqlCourse.Field.IsFree, this);
            }
        }

        public SqlExpressionFieldBoolean IsFull {
            get {
                return new SqlExpressionFieldBoolean(SqlCourse.Field.IsFull, this);
            }
        }

        public SqlExpressionFieldDateTime RegistrationDeadLine {
            get {
                return new SqlExpressionFieldDateTime(SqlCourse.Field.RegistrationDeadLine, this);
            }
        }

        public SqlExpressionFieldShortString CoursePicture_course_picture_filename {
            get {
                return new SqlExpressionFieldShortString(SqlCourse.Field.CoursePicture_course_picture_filename, this);
            }
        }

        public SqlExpressionFieldShortString CoursePicture_course_picture_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlCourse.Field.CoursePicture_course_picture_type_name, this);
            }
        }

        public SqlExpressionFieldShortString CoursePicture_course_picture_extension {
            get {
                return new SqlExpressionFieldShortString(SqlCourse.Field.CoursePicture_course_picture_extension, this);
            }
        }

        public SqlExpressionFieldFloat CoursePicture_course_picture_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlCourse.Field.CoursePicture_course_picture_bytes, this);
            }
        }

        public SqlExpressionFieldLongString CoursePicture_course_picture_info {
            get {
                return new SqlExpressionFieldLongString(SqlCourse.Field.CoursePicture_course_picture_info, this);
            }
        }

        public SqlExpressionFieldInteger CoursePicture_course_picture_int {
            get {
                return new SqlExpressionFieldInteger(SqlCourse.Field.CoursePicture_course_picture_int, this);
            }
        }

    }
}
namespace WAF.Engine.Query.MySite {
    [System.Serializable]
    public partial class AqlCourse{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")); 
            }
        }

        public static AqlPropertyDateTime Start {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.MySite.SqlCourse.Field.Start, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyDateTime End {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.MySite.SqlCourse.Field.End, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlCourse.Field.Description, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyInteger Price {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlCourse.Field.Price, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyInteger NumberOfSeats {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlCourse.Field.NumberOfSeats, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean IsFree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.MySite.SqlCourse.Field.IsFree, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean IsFull {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.MySite.SqlCourse.Field.IsFull, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyRelation Instructors {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("063fed50-4853-4d86-8d8d-dcb54d144e8b"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasCourse(), new WAF.Engine.Query.MySite.AqlAliasInstructor(), WAF.Engine.Query.MySite.AqlRelCoursesIntructors.Relation));
            }
        }

        public static AqlPropertyRelation Participants {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("56204a02-f18d-46b0-a393-2207c1b504c7"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasCourse(), new WAF.Engine.Query.MySite.AqlAliasParticipant(), WAF.Engine.Query.MySite.AqlRelCoursesParticipants.Relation));
            }
        }

        public static AqlPropertyDateTime RegistrationDeadLine {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.MySite.SqlCourse.Field.RegistrationDeadLine, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyRelation Categories {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("aa60882a-94a9-4bba-b05a-0909b043b6b2"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasCourse(), new WAF.Engine.Query.MySite.AqlAliasCategory(), WAF.Engine.Query.MySite.AqlRelCoursesCategories.Relation));
            }
        }

        public static AqlPropertyShortString CoursePicture_course_picture_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlCourse.Field.CoursePicture_course_picture_filename, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyShortString CoursePicture_course_picture_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlCourse.Field.CoursePicture_course_picture_type_name, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyShortString CoursePicture_course_picture_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.MySite.SqlCourse.Field.CoursePicture_course_picture_extension, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyFloat CoursePicture_course_picture_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.MySite.SqlCourse.Field.CoursePicture_course_picture_bytes, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyLongString CoursePicture_course_picture_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.MySite.SqlCourse.Field.CoursePicture_course_picture_info, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyInteger CoursePicture_course_picture_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.MySite.SqlCourse.Field.CoursePicture_course_picture_int, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyRelation Venues {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("b531a89f-4b7a-400f-ad2b-4b0daf5ea3f9"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasCourse(), new WAF.Engine.Query.MySite.AqlAliasVenue(), WAF.Engine.Query.MySite.AqlRelCoursesVenues.Relation));
            }
        }

        public static AqlPropertyRelation RegistrationForms {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("43c8b7de-6709-4da5-a68d-7981f06b64cd"), new AqlAliasRelation(new WAF.Engine.Query.MySite.AqlAliasCourse(), new WAF.Engine.Query.MySite.AqlAliasRegistrationForms(), WAF.Engine.Query.MySite.AqlRelCoursesRegistrationForms.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasCourse
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasCourse()
            : base(WAFID.GetContentClassId("fdb92bac-b379-43ec-b327-02cc014b0ac5")) {

        }

        public AqlAliasCourse(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyDateTime Start {
            get {
                return new AqlExpressionPropertyDateTime(AqlCourse.Start, this);
            }
        }

        public AqlExpressionPropertyDateTime End {
            get {
                return new AqlExpressionPropertyDateTime(AqlCourse.End, this);
            }
        }

        public AqlExpressionPropertyLongString Description {
            get {
                return new AqlExpressionPropertyLongString(AqlCourse.Description, this);
            }
        }

        public AqlExpressionPropertyInteger Price {
            get {
                return new AqlExpressionPropertyInteger(AqlCourse.Price, this);
            }
        }

        public AqlExpressionPropertyInteger NumberOfSeats {
            get {
                return new AqlExpressionPropertyInteger(AqlCourse.NumberOfSeats, this);
            }
        }

        public AqlExpressionPropertyBoolean IsFree {
            get {
                return new AqlExpressionPropertyBoolean(AqlCourse.IsFree, this);
            }
        }

        public AqlExpressionPropertyBoolean IsFull {
            get {
                return new AqlExpressionPropertyBoolean(AqlCourse.IsFull, this);
            }
        }

        public AqlExpressionPropertyDateTime RegistrationDeadLine {
            get {
                return new AqlExpressionPropertyDateTime(AqlCourse.RegistrationDeadLine, this);
            }
        }

        public AqlExpressionPropertyShortString CoursePicture_course_picture_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlCourse.CoursePicture_course_picture_filename, this);
            }
        }

        public AqlExpressionPropertyShortString CoursePicture_course_picture_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlCourse.CoursePicture_course_picture_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString CoursePicture_course_picture_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlCourse.CoursePicture_course_picture_extension, this);
            }
        }

        public AqlExpressionPropertyFloat CoursePicture_course_picture_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlCourse.CoursePicture_course_picture_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString CoursePicture_course_picture_info {
            get {
                return new AqlExpressionPropertyLongString(AqlCourse.CoursePicture_course_picture_info, this);
            }
        }

        public AqlExpressionPropertyInteger CoursePicture_course_picture_int {
            get {
                return new AqlExpressionPropertyInteger(AqlCourse.CoursePicture_course_picture_int, this);
            }
        }

    }
}
