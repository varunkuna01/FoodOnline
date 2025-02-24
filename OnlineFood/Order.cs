using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood1
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   
        public int OrderID { get; set; }
        //[Foreign Key(customer)]
        public int CustomerID { get; set; }
        //[Foreign Key(customer)]
        public int RestaurantID { get; set; }
        public string? Status { get; set; } // Pending, Accepted, Preparing, Delivered
        [Column(TypeName = "decimal(18,2)")][Range(0, 9999999999999999.99, ErrorMessage = "Total Amount must be between 0 and 9999999999999999.99")] public decimal TotalAmount { get; set; }

        //public virtual Order? orders { get; set; }
    }
}
