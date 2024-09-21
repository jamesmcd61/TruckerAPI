namespace TuckerAPIProject.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Package")]
    public class PackageModel
    {
        [Key]
        public int Id { get; set; } 

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}
