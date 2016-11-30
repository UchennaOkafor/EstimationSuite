using System.Runtime.Serialization;

namespace Suite.Models
{
    [DataContract]
    public class Part
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }


        [DataMember(Name = "name")]
        public string Name { get; set; }


        [DataMember(Name = "weight")]
        public double Weight { get; set; }


        [DataMember(Name = "units")]
        public int Units { get; set; }


        [DataMember(Name = "stock")]
        public int Stock { get; set; }


        [DataMember(Name = "length")]
        public double Length { get; set; }


        [DataMember(Name = "width")]
        public double Width { get; set; }


        [DataMember(Name = "sales_price")]
        public double SalesPrice { get; set; }


        [DataMember(Name = "purchase_price")]
        public double PurchasePrice { get; set; }


        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }


        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }


        [DataMember(Name = "pivot")]
        public PartPivot Pivot { get; set; }


        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
