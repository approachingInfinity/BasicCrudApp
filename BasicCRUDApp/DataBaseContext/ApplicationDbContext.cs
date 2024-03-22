using BasicCRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUDApp.DataBaseContext
{
    public class ApplicationDbContext:DbContext
    {

    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options)
        { 

        }

        public virtual DbSet<Book> books { get; set; }

        public virtual DbSet<Contact> contacts { get; set; }
        public virtual DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("books");
            modelBuilder.Entity<Contact>().ToTable("contacts");
            modelBuilder.Entity<Product>().ToTable("products");
        }
    }
}
