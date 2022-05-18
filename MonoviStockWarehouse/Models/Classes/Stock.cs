using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        public int CategoryID { get; set; }
        public int TypeID { get; set; }
        public bool ReturnOrNew { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PCode { get; set; }
        public string BINNO { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Amount { get; set; }
        public DateTime ExpDate { get; set; }
        public int ProductID { get; set; }
        public Category Category { get; set; }


    }
}
