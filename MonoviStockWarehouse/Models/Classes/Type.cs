using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class Type
    {
        [Key]
        public int TypeID { get; set; }
        public int CategoryID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TypeName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string TypeUnit { get; set; }
        public Category Category { get; set; }



    }
}