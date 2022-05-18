using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class BIN
    {
        [Key]
        public int ProductCodeID { get; set; }
        public string BINNO { get; set; }
        public DateTime ExpDate { get; set; }

    }
}