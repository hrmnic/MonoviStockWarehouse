using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }
        public int RequestID { get; set; }
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
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string Contact { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string SSCC { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

    }
}