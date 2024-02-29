using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalAssigment_2.Model
{
    public class Order
    {
        // Primary key for the database
        [Key]
        [Required(ErrorMessage = "Order ID is required.")]
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        // Foreign key for Customer
        [Display(Name = "Customer ID")]
        [Required(ErrorMessage = "Customer ID is required.")]
        public int CustomerID { get; set; }

        // Navigation property to represent the relationship with the Customer table
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        // Date the order was placed
        [Display(Name = "Order Date")]
        [Required(ErrorMessage = "Order date is required.")]
        public DateTime OrderDate { get; set; }

        // Date the order is required to be delivered
        [Display(Name = "Required Date")]
        [Required(ErrorMessage = "Required date is required.")]
        public DateTime? RequiredDate { get; set; }

        // Date the order was shipped
        [Display(Name = "Shipped Date")]
        [Required(ErrorMessage = "Shipped date is required.")]
        public DateTime? ShippedDate { get; set; }

        // Freight cost for the order
        [Display(Name = "Freight")]
        [Required(ErrorMessage = "Freight is required.")]
        public decimal Freight { get; set; }

        // Delivery address for the order
        [Display(Name = "Ship Address")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Delivery address is required.")]
        public string ShipAddress { get; set; }
    }
}
