using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Suite.Models
{
    [DataContract]
    public class Project
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }


        [DataMember(Name = "name")]
        public string Name { get; set; }


        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }


        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }


        [DataMember(Name = "sets")]
        public List<Set> Sets { get; set; }


        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}