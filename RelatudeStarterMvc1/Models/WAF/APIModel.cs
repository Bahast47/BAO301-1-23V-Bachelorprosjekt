// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using System;
using System.Linq;
using System.Collections.Generic;
namespace WAF.API { public class CustomDefinition{ } };

namespace WAF.API.MySite {
[ClassGuid("405504e2-9586-4c8d-8f05-9a0b3c02a05d")]
public class HelloWorld : WAF.API.Native.HierarchicalContent {
public HelloWorld(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _ingressGuid = new Guid("fc864cce-8aac-4122-9ae8-2cf41b6d6bc9");
        [PropertyGuid("fc864cce-8aac-4122-9ae8-2cf41b6d6bc9")]
        public string Ingress {
        get { return (string)DataProvider.GetPropertyValue(_ingressGuid); }
        set { DataProvider.SetPropertyValue(_ingressGuid, value); }
        }
      
        static Guid _ingressPicureGuid = new Guid("b31cd878-73d5-4825-ac9e-641c5de60d26");
        [PropertyGuid("b31cd878-73d5-4825-ac9e-641c5de60d26")]
        public PropertyTypes.FileInfo IngressPicure {
        get { return DataProvider.GetFileInfo(_ingressPicureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _contentGuid = new Guid("6efcf974-a668-46cc-bb9e-0cfec8306a17");
        [PropertyGuid("6efcf974-a668-46cc-bb9e-0cfec8306a17")]
        public string Content {
        get { return (string)DataProvider.GetPropertyValue(_contentGuid); }
        set { DataProvider.SetPropertyValue(_contentGuid, value); }
        }
      
        static Guid _filesGuid = new Guid("f7daf615-e788-48bd-a1ca-c2cd5d55f6c4");
        [PropertyGuid("f7daf615-e788-48bd-a1ca-c2cd5d55f6c4")]
        public System.Collections.Generic.List<WAF.API.Native.InnerContentBase> Files {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_filesGuid)).Cast<WAF.API.Native.InnerContentBase>().ToList();}
        set {DataProvider.SetPropertyValue(_filesGuid, value);}
        }
      
}
}
