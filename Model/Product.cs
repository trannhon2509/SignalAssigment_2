using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalAssigment_2.Model
{
    public class Product
    {
        // Primary key for the database
        [Key]
        [Required]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        // ProductName property with validation for required field and maximum length
        [Required(ErrorMessage = "Product Name is required.")]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        // SupplierID property
        [Display(Name = "Supplier ID")]
        public int SupplierID { get; set; }

        // CategoryID property
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        // QuantityPerUnit property with validation for required field and maximum length
        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(20)")]
        [Display(Name = "Quantity Per Unit")]
        public string QuantityPerUnit { get; set; }

        // UnitPrice property
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        // ProductImage property with column type specification
        [Column(TypeName = "nvarchar(300)")]
        [Display(Name = "Product Image")]
        public string? ProductImage { get; set; }
    }
}
