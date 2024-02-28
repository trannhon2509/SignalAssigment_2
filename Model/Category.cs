using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalAssigment_2.Model
{
    public class Category
    {
        [Key]
        [Required]
        public Guid CategoryID { get; set; }

        [Required(ErrorMessage = "CategoryName is required!")]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayFormat(NullDisplayText = "No description.")]
        public string? Description { get; set; }

        ICollection<Product> Products { get; set; }
    }
}
