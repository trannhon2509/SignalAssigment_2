using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalAssigment_2.Model
{
    public class Account
    {
        // Primary key for the database with identity specification
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Account ID is required.")]
        [Display(Name = "Account ID")]
        public int AccountID { get; set; }

        // UserName property with required validation and column type specification
        [Required(ErrorMessage = "User Name is required.")]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        // Password property with required validation and column type specification
        [Required(ErrorMessage = "Password is required.")]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        // FullName property with required validation and column type specification
        [Required(ErrorMessage = "Full Name is required.")]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        // Type property with range validation
        [Range(0, 1, ErrorMessage = "Only accept 1 or 0.")]
        [Display(Name = "Type")]
        public byte? Type { get; set; }
    }
}
