using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class Shipment
    {
        [Key]
        public int ShipmentID { get; set; }
        public int OrderID { get; set; }
        public int Miles { get; set; }
        public int NumberPlate1 { get; set; }
        public int NumberPlate2 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string DriverName1 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string DriverName2 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string DriverIdentity1 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string DriverIdentity2 { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}