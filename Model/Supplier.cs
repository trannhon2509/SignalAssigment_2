using SignalAssigment_2.Utils;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalAssigment_2.Model
{
    public class Supplier
    {
        // Primary key for the database
        [Key]
        [Required]
        [Display(Name = "Supplier ID")]
        public int SupplierID { get; set; }

        // CompanyName property with validation for required field and maximum length
        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        // Address property with validation for required field and maximum length
        [Required(ErrorMessage = "Address is required.")]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        // Phone property with validation for required field, maximum length, and custom validation using PhoneNumberValidation attribute
        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(20)")]
        [PhoneNumberValidation]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}
