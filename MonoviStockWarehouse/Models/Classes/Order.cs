using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int RequestID { get; set; }
        public int StockID { get; set; }
        public string SSCC { get; set; }
        public int ProductCodeID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description { get; set; }
        public string BINNO { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Unit { get; set; }
        public int Amount { get; set; }
        public Shipment Shipment { get; set; }
        public RequestForm RequestForm { get; set; }
    }
}