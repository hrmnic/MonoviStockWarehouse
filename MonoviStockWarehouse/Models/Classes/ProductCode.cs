using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class ProductCode
    {
        [Key]
        public int ProductCodeID { get; set; }
        public int TypeID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PCode { get; set; }
        public Type Type { get; set; } 
         
    }
}