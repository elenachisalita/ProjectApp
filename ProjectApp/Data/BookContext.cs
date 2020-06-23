using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
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

    }
}
