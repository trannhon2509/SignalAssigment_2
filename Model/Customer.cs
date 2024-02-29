using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SignalAssigment_2.Utils;

namespace SignalAssigment_2.Model
{
    public class Customer
    {
        // Primary key for the database with identity specification
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Customer ID is required.")]
        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        // Password property with column type specification and required validation
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        // ContactName property with column type specification and required validation
        [Required(ErrorMessage = "Contact Name is required")]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        // Address property with column type specification and required validation
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        // Phone property with maximum length, required validation, and custom validation using PhoneNumberValidation attribute
        [Required(ErrorMessage = "Phone is required!")]
        [MaxLength(20)]
        [PhoneNumberValidation]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}
