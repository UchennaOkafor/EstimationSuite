using System.Runtime.Serialization;

namespace Suite.Models
{
    [DataContract]
    public class Statistics
    {
        [DataMember(Name = "total_projects")]
        public int TotalProjects { get; set; }


        [DataMember(Name = "total_sets")]
        public int TotalSets { get; set; }


        [DataMember(Name = "total_parts")]
        public int TotalParts { get; set; }
    }
}