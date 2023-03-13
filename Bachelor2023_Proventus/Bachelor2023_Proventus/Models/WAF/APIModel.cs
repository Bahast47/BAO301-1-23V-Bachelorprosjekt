// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using System;
using System.Linq;
using System.Collections.Generic;
namespace WAF.API { public class CustomDefinition{ } };

namespace WAF.API.MySite {
[ClassGuid("fdb92bac-b379-43ec-b327-02cc014b0ac5")]
public class Course : WAF.API.Native.HierarchicalContent {
public Course(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _startGuid = new Guid("f18db84f-6f95-4769-ac35-3e441378faa0");
        [PropertyGuid("f18db84f-6f95-4769-ac35-3e441378faa0")]
        public DateTime Start {
        get { return (DateTime)DataProvider.GetPropertyValue(_startGuid); }
        set { DataProvider.SetPropertyValue(_startGuid, value); }
        }
      
        static Guid _endGuid = new Guid("2d42b3bd-d02e-4f66-aa34-79f983405cbc");
        [PropertyGuid("2d42b3bd-d02e-4f66-aa34-79f983405cbc")]
        public DateTime End {
        get { return (DateTime)DataProvider.GetPropertyValue(_endGuid); }
        set { DataProvider.SetPropertyValue(_endGuid, value); }
        }
      
        static Guid _descriptionGuid = new Guid("1215da0f-60c3-487b-8d1a-a54f8cd1fb73");
        [PropertyGuid("1215da0f-60c3-487b-8d1a-a54f8cd1fb73")]
        public string Description {
        get { return (string)DataProvider.GetPropertyValue(_descriptionGuid); }
        set { DataProvider.SetPropertyValue(_descriptionGuid, value); }
        }
      
        static Guid _priceGuid = new Guid("2236e349-c510-4e77-9ac5-df1267d03327");
        [PropertyGuid("2236e349-c510-4e77-9ac5-df1267d03327")]
        public int Price {
        get { return (int)DataProvider.GetPropertyValue(_priceGuid); }
        set { DataProvider.SetPropertyValue(_priceGuid, value); }
        }
      
        static Guid _numberOfSeatsGuid = new Guid("ebce4c2c-87cc-4d2e-830c-da015db14df5");
        [PropertyGuid("ebce4c2c-87cc-4d2e-830c-da015db14df5")]
        public int NumberOfSeats {
        get { return (int)DataProvider.GetPropertyValue(_numberOfSeatsGuid); }
        set { DataProvider.SetPropertyValue(_numberOfSeatsGuid, value); }
        }
      
        static Guid _isFreeGuid = new Guid("37b35cbd-b7d3-4322-ac2a-05e84ec8cdfd");
        [PropertyGuid("37b35cbd-b7d3-4322-ac2a-05e84ec8cdfd")]
        public bool IsFree {
        get { return (bool)DataProvider.GetPropertyValue(_isFreeGuid); }
        set { DataProvider.SetPropertyValue(_isFreeGuid, value); }
        }
      
        static Guid _isFullGuid = new Guid("bb5aebc1-d4e2-4b02-82d2-caf0fb7803c5");
        [PropertyGuid("bb5aebc1-d4e2-4b02-82d2-caf0fb7803c5")]
        public bool IsFull {
        get { return (bool)DataProvider.GetPropertyValue(_isFullGuid); }
        set { DataProvider.SetPropertyValue(_isFullGuid, value); }
        }
      
        static Guid _instructorsGuid = new Guid("063fed50-4853-4d86-8d8d-dcb54d144e8b");
        [PropertyGuid("063fed50-4853-4d86-8d8d-dcb54d144e8b")]
        public IQueryable<WAF.API.MySite.Instructor> Instructors {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_instructorsGuid)).Cast<WAF.API.MySite.Instructor>();}
        set {DataProvider.SetPropertyValue(_instructorsGuid, value);}
        }
      
        static Guid _participantsGuid = new Guid("56204a02-f18d-46b0-a393-2207c1b504c7");
        [PropertyGuid("56204a02-f18d-46b0-a393-2207c1b504c7")]
        public IQueryable<WAF.API.MySite.Participant> Participants {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_participantsGuid)).Cast<WAF.API.MySite.Participant>();}
        set {DataProvider.SetPropertyValue(_participantsGuid, value);}
        }
      
        static Guid _registrationDeadLineGuid = new Guid("952a4b9e-481b-4e24-ac7f-3d8e7e406ff2");
        [PropertyGuid("952a4b9e-481b-4e24-ac7f-3d8e7e406ff2")]
        public DateTime RegistrationDeadLine {
        get { return (DateTime)DataProvider.GetPropertyValue(_registrationDeadLineGuid); }
        set { DataProvider.SetPropertyValue(_registrationDeadLineGuid, value); }
        }
      
        static Guid _categoriesGuid = new Guid("aa60882a-94a9-4bba-b05a-0909b043b6b2");
        [PropertyGuid("aa60882a-94a9-4bba-b05a-0909b043b6b2")]
        public IQueryable<WAF.API.MySite.Category> Categories {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_categoriesGuid)).Cast<WAF.API.MySite.Category>();}
        set {DataProvider.SetPropertyValue(_categoriesGuid, value);}
        }
      
        static Guid _coursePictureGuid = new Guid("07d321db-3b0d-41c6-bcb3-5cdc0088b9c9");
        [PropertyGuid("07d321db-3b0d-41c6-bcb3-5cdc0088b9c9")]
        public PropertyTypes.FileInfo CoursePicture {
        get { return DataProvider.GetFileInfo(_coursePictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _venuesGuid = new Guid("b531a89f-4b7a-400f-ad2b-4b0daf5ea3f9");
        [PropertyGuid("b531a89f-4b7a-400f-ad2b-4b0daf5ea3f9")]
        public IQueryable<WAF.API.MySite.Venue> Venues {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_venuesGuid)).Cast<WAF.API.MySite.Venue>();}
        set {DataProvider.SetPropertyValue(_venuesGuid, value);}
        }
      
        static Guid _registrationFormsGuid = new Guid("43c8b7de-6709-4da5-a68d-7981f06b64cd");
        [PropertyGuid("43c8b7de-6709-4da5-a68d-7981f06b64cd")]
        public IQueryable<WAF.API.MySite.RegistrationForms> RegistrationForms {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_registrationFormsGuid)).Cast<WAF.API.MySite.RegistrationForms>();}
        set {DataProvider.SetPropertyValue(_registrationFormsGuid, value);}
        }
      
}
}

namespace WAF.API.MySite {
[ClassGuid("1429c01d-9448-47a1-a435-3752f4231526")]
public class Instructor : WAF.API.Native.HierarchicalContent {
public Instructor(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _coursesGuid = new Guid("dfc967a2-0ae1-476e-b185-ba621174ad5a");
        [PropertyGuid("dfc967a2-0ae1-476e-b185-ba621174ad5a")]
        public IQueryable<WAF.API.MySite.Course>
        Courses {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_coursesGuid)).Cast<WAF.API.MySite.Course>();}
        set {DataProvider.SetPropertyValue(_coursesGuid, value);}
        }
      
        static Guid _descriptionGuid = new Guid("7d6cd5cf-16ed-46cf-a267-dd4cf43edc0f");
        [PropertyGuid("7d6cd5cf-16ed-46cf-a267-dd4cf43edc0f")]
        public string Description {
        get { return (string)DataProvider.GetPropertyValue(_descriptionGuid); }
        set { DataProvider.SetPropertyValue(_descriptionGuid, value); }
        }
      
        static Guid _linkedinGuid = new Guid("3e4a3fd6-c861-443f-947d-0b6d73d14931");
        [PropertyGuid("3e4a3fd6-c861-443f-947d-0b6d73d14931")]
        public string Linkedin {
        get { return (string)DataProvider.GetPropertyValue(_linkedinGuid); }
        set { DataProvider.SetPropertyValue(_linkedinGuid, value); }
        }
      
        static Guid _instagramGuid = new Guid("d068c542-8298-4842-b16b-d98d79927b96");
        [PropertyGuid("d068c542-8298-4842-b16b-d98d79927b96")]
        public string Instagram {
        get { return (string)DataProvider.GetPropertyValue(_instagramGuid); }
        set { DataProvider.SetPropertyValue(_instagramGuid, value); }
        }
      
        static Guid _epostGuid = new Guid("e7220d11-e68d-49f6-b181-b40e0c7aa473");
        [PropertyGuid("e7220d11-e68d-49f6-b181-b40e0c7aa473")]
        public string Epost {
        get { return (string)DataProvider.GetPropertyValue(_epostGuid); }
        set { DataProvider.SetPropertyValue(_epostGuid, value); }
        }
      
        static Guid _phoneNumberGuid = new Guid("4d97f034-970e-4462-8231-801557edb941");
        [PropertyGuid("4d97f034-970e-4462-8231-801557edb941")]
        public int PhoneNumber {
        get { return (int)DataProvider.GetPropertyValue(_phoneNumberGuid); }
        set { DataProvider.SetPropertyValue(_phoneNumberGuid, value); }
        }
      
        static Guid _instructorPictureGuid = new Guid("f27eb826-632c-4b83-98d9-3fbb052c3d3c");
        [PropertyGuid("f27eb826-632c-4b83-98d9-3fbb052c3d3c")]
        public PropertyTypes.FileInfo InstructorPicture {
        get { return DataProvider.GetFileInfo(_instructorPictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
}
}

namespace WAF.API.MySite {
[ClassGuid("9dacbbbc-60d9-4edc-baf0-a6cc823a528a")]
public class Participant : WAF.API.Native.SystemUser {
public Participant(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _coursesGuid = new Guid("4bc57171-1e3c-4534-ba59-e28164ee259f");
        [PropertyGuid("4bc57171-1e3c-4534-ba59-e28164ee259f")]
        public IQueryable<WAF.API.MySite.Course>
        Courses {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_coursesGuid)).Cast<WAF.API.MySite.Course>();}
        set {DataProvider.SetPropertyValue(_coursesGuid, value);}
        }
      
        static Guid _allergiesGuid = new Guid("1975cc28-d702-4bec-b504-d4aaa5377fff");
        [PropertyGuid("1975cc28-d702-4bec-b504-d4aaa5377fff")]
        public string Allergies {
        get { return (string)DataProvider.GetPropertyValue(_allergiesGuid); }
        set { DataProvider.SetPropertyValue(_allergiesGuid, value); }
        }
      
}
}

namespace WAF.API.MySite {
[ClassGuid("5f3c2f6c-1e99-4aeb-b3f5-283252fe4387")]
public class Venue : WAF.API.Native.HierarchicalContent {
public Venue(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _mapsLinkGuid = new Guid("1aa28122-2253-42f1-bad1-ddf57b44cb36");
        [PropertyGuid("1aa28122-2253-42f1-bad1-ddf57b44cb36")]
        public string MapsLink {
        get { return (string)DataProvider.GetPropertyValue(_mapsLinkGuid); }
        set { DataProvider.SetPropertyValue(_mapsLinkGuid, value); }
        }
      
        static Guid _homeSiteGuid = new Guid("4d04ed51-8d6e-4c63-98e4-c90b1ffddf73");
        [PropertyGuid("4d04ed51-8d6e-4c63-98e4-c90b1ffddf73")]
        public string HomeSite {
        get { return (string)DataProvider.GetPropertyValue(_homeSiteGuid); }
        set { DataProvider.SetPropertyValue(_homeSiteGuid, value); }
        }
      
        static Guid _venuePictureGuid = new Guid("c5dd1a62-b082-4bf5-aca6-ec2634ea067d");
        [PropertyGuid("c5dd1a62-b082-4bf5-aca6-ec2634ea067d")]
        public PropertyTypes.FileInfo VenuePicture {
        get { return DataProvider.GetFileInfo(_venuePictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _coursesGuid = new Guid("ad136095-b662-436f-b3f0-7a15dea1db2b");
        [PropertyGuid("ad136095-b662-436f-b3f0-7a15dea1db2b")]
        public IQueryable<WAF.API.MySite.Course>
        Courses {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_coursesGuid)).Cast<WAF.API.MySite.Course>();}
        set {DataProvider.SetPropertyValue(_coursesGuid, value);}
        }
      
        static Guid _venueAdressGuid = new Guid("85bcd471-9ee5-47cd-ab93-e23420a573d7");
        [PropertyGuid("85bcd471-9ee5-47cd-ab93-e23420a573d7")]
        public string VenueAdress {
        get { return (string)DataProvider.GetPropertyValue(_venueAdressGuid); }
        set { DataProvider.SetPropertyValue(_venueAdressGuid, value); }
        }
      
}
}

namespace WAF.API.MySite {
[ClassGuid("94ce9a05-e7cd-426f-821f-967264ab6ed1")]
public class Category : WAF.API.Native.HierarchicalContent {
public Category(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _coursesGuid = new Guid("7ce24a13-17d8-47a6-865c-cfa0832d0b6b");
        [PropertyGuid("7ce24a13-17d8-47a6-865c-cfa0832d0b6b")]
        public IQueryable<WAF.API.MySite.Course>
        Courses {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_coursesGuid)).Cast<WAF.API.MySite.Course>();}
        set {DataProvider.SetPropertyValue(_coursesGuid, value);}
        }
      
}
}

namespace WAF.API.MySite {
[ClassGuid("ba72d9fc-6643-402c-a125-f3b08362fb75")]
public class RegistrationForms : WAF.API.Native.HierarchicalContent {
public RegistrationForms(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _formContainerGuid = new Guid("eaf8f447-4825-44d1-9cc8-c9b85f682b36");
        [PropertyGuid("eaf8f447-4825-44d1-9cc8-c9b85f682b36")]
        public string FormContainer {
        get { return (string)DataProvider.GetPropertyValue(_formContainerGuid); }
        set { DataProvider.SetPropertyValue(_formContainerGuid, value); }
        }
      
        static Guid _signUpGuid = new Guid("b8174d88-664d-4190-8fd5-0dc46e26949c");
        [PropertyGuid("b8174d88-664d-4190-8fd5-0dc46e26949c")]
        public string SignUp {
        get { return (string)DataProvider.GetPropertyValue(_signUpGuid); }
        set { DataProvider.SetPropertyValue(_signUpGuid, value); }
        }
      
        static Guid _courseGuid = new Guid("11935030-00c9-43d8-a2eb-ac0c97cdad6d");
        [PropertyGuid("11935030-00c9-43d8-a2eb-ac0c97cdad6d")]
        public IQueryable<WAF.API.MySite.Course>
        Course {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_courseGuid)).Cast<WAF.API.MySite.Course>();}
        set {DataProvider.SetPropertyValue(_courseGuid, value);}
        }
      
}
}
