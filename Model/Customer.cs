using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SignalAssigment_2.Utils;

namespace SignalAssigment_2.Model
{
    public class Customer
    {
        [Key]
        [Required]
        public Guid CustomerID { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ContactName is required")]
        [Column(TypeName = "nvarchar(100)")]
        public string ContactName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone is required!")]
        [MaxLength(20)]
        [PhoneNumberValidation]
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
