using System.Runtime.Serialization;

namespace Suite.Models
{
    [DataContract]
    public class SetPivot
    {
        [DataMember(Name = "id")]
        public int ProjectSetId { get; set; }


        [DataMember(Name = "set_id")]
        public int SetId { get; set; }
    }

    public class PartPivot
    {

        [DataMember(Name = "set_id")]
        public int SetId { get; set; }


        [DataMember(Name = "part_id")]
        public int PartId { get; set; }
    }
}