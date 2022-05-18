using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Type> Types { get; set; }
    }
}