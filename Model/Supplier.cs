using SignalAssigment_2.Utils;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalAssigment_2.Model
{
    public class Supplier
    {
        [Key]
        [Required]
        public Guid SupplierID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(20)")]
        [PhoneNumberValidation]
        public string Phone { get; set; }

        ICollection<Product> Products { get; set; }
    }
}
