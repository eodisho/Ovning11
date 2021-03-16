using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data
{
    //StorageContext klass  använder sig av EntityFramework(ORM mappar mellan databasen och vår C# kod).
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }
        //property av typen DbSet<Product> Product som vi använder oss av för att
        //hämta data från databasen(Titta på den genererade koden i ProductsController).
        public DbSet<Storage.Models.ProductModel> Product { get; set; }
    }
}
