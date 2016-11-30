using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Suite.Models
{
    [DataContract]
    public class Set
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }


        [DataMember(Name = "name")]
        public string Name { get; set; }


        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }


        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }


        [DataMember(Name = "parts")]
        public List<Part> Parts { get; set; }


        [DataMember(Name = "pivot")]
        public SetPivot Pivot { get; set; }


        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
