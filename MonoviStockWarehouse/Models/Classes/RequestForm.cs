using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class RequestForm
    {
        [Key]
        public int RequestID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CompanyName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string CompanyAddress { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string Contact { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Tax { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string DeliveryAddress { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string InvoiceAddress { get; set; }
        public int ProductCodeID { get; set; }
        public int Amount { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}