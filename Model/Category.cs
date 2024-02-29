using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalAssigment_2.Model
{
    public class Category
    {
        // Primary key for the database with identity specification
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Category ID is required.")]
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        // CategoryName property with required validation and maximum length
        [Required(ErrorMessage = "Category Name is required!")]
        [MaxLength(50)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        // Description property with column type specification and display format for null values
        [Column(TypeName = "nvarchar(250)")]
        [DisplayFormat(NullDisplayText = "No description.")]
        [Display(Name = "Description")]
        public string? Description { get; set; }
    }
}
