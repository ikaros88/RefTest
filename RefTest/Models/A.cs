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
    [KnownType(typeof(B))]
    [JsonConverter(typeof(JsonInheritanceConverter), "discriminator")]
    public class A
    {
        [DataMember]
        public List<C> Children { get; set; }

        [DataMember]
        public string AString { get; set; }
    }
}
