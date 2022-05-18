using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Column(TypeName="Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public int StockID { get; set; }
        public decimal BuyingPrice{ get; set; }
        public decimal SalePrice{ get; set; }
        public DateTime ExpDate { get; set; }
        public string ProductImage { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string SenderCompany { get; set; }
        public bool ReturnOrNew { get; set; }
        public int ProductCodeID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description { get; set; }
        public int Amount { get; set; }
        public Category Category { get; set; }


    }
}