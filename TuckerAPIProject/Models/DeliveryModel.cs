namespace TuckerAPIProject.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Delivery")]
    public class DeliveryModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string? Summary { get; set; }

        public string Location { get; set; }

        public int PackageId { get; set; }

        public virtual PackageModel Package { get; set; }

        public int TruckerInfoId { get; set; }

        public virtual TruckerInfoModel TruckerInfo { get; set; }
    }
}