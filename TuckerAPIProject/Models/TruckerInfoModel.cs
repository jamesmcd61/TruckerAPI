namespace TuckerAPIProject.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TruckerInfo")]
    public class TruckerInfoModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public long Age { get; set; }

        public int PackageId { get; set; }

        public virtual PackageModel Package { get; set; }
    }
}
