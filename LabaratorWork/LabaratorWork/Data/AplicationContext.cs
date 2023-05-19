using LabaratorWork.Model;
using Microsoft.EntityFrameworkCore;
using System.IO;


namespace LabaratorWork.Data
{
   public class AplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AplicationContext()
        {
            Database.EnsureCreated();
        }


        string folderpath = Path.Combine(Directory.GetCurrentDirectory(), @"DB\Products.db");
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Suorce = {folderpath}");
        }
    }
}
