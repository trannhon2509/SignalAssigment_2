using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalAssigment_2.Model
{
    public class OrderDetail
    {
        // Primary key for the database
        [Key]
        [Required]
        [Display(Name = "Order Detail ID")]
        public int OrderDetailID { get; set; }

        // Foreign key for Order
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        // Navigation property to represent the relationship with the Order table
        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        // Foreign key for Product
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        // Navigation property to represent the relationship with the Product table
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        // UnitPrice property
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        // Quantity property
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
    }
}
