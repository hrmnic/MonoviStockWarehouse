using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MonoviStockWarehouse.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BIN> BINs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCode> ProductCodes { get; set; }
        public DbSet<RequestForm> RequestForms { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Type> Types { get; set; }

    }
}