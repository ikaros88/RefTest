using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RefTest.Models
{
    [DataContract(IsReference = true)]
    public class C
    {
        [DataMember]
        public A Parent { get; set; }

        [DataMember]
        public string CString { get; set; }
    }
}
