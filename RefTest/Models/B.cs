using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NJsonSchema.Converters;

namespace RefTest.Models
{
    [DataContract(IsReference = true)]
    public class B : A
    {
        [DataMember]
        public string BString { get; set; }
    }
}
