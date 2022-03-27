﻿using Microsoft.EntityFrameworkCore;
using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Data
{
    public class ApplicationDbContext : DbContext
    {
        // the dbset property will tell ef core that we have
        // a table that needs to be created if doesnt exist
        
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductType { get; set; } 
        public DbSet<ProductBrands> ProductBrands { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
