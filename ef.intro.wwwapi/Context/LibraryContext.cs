using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ef.intro.wwwapi.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            
            //if (!this.Authors.Any())
            //{
            //    using (var db = this)
            //    {
            //        var authors = new List<Author>()
            //        {
            //            new Author { Id = 1, FirstName = "Joseph", LastName = "Albahari" },
            //            new Author { Id = 2, FirstName = "Robert", LastName = "Nickerson" },
            //            new Author { Id = 3, FirstName = "Dan", LastName = "Pilone" }
            //        };
            //        db.Authors.AddRange(authors);
            //        db.SaveChanges();
            //    }
                    
            //}

            //if (!this.Books.Any())
            //{
            //    var books = new List<Book>()
            //    {
            //        new Book { Id = 1, Title="C# 10", AuthorId=1 },
            //        new Book { Id = 2, Title = "Fundamental of Structured COBOL", AuthorId = 2 },
            //        new Book { Id = 3, Title = "UML", AuthorId = 3 }
            //    };
            //    this.Books.AddRange(books);
            //    this.SaveChanges();
            //}
           
            

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "Library");
            

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
           .HasKey(m => new { m.Id });

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
