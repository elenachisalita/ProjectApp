using Microsoft.EntityFrameworkCore;
using ProjectApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order>Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().HasData
                (new Order()
                {
                    Id = 1,
                    OrderDate = DateTime.UtcNow,
                    OrderNumber = "12345"
                });
        }

    }
}
