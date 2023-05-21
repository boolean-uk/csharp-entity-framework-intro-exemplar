﻿using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace ef.intro.wwwapi.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        public LibraryRepository() 
        { 
        
        }  
        public bool AddAuthor(Author author)
        {
            using(var db = new LibraryContext())
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public IEnumerable<Author> GetAllAuthors()
        {            
            using (var db = new LibraryContext())
            {
                return db.Authors.Include(a => a.Books).ToList();
            }
            return null;
        }

        public bool AddBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                throw new NotImplementedException(); //TODO: Remove this line and add code
                return true;
            };
            return false;
        }

        public bool DeleteAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                throw new NotImplementedException(); //TODO: Remove this line and add code
                return true;
            };
            return false;
        }

        public bool DeleteBook(int id)
        {
            using (var db = new LibraryContext())
            {
                throw new NotImplementedException(); //TODO: Remove this line and add code
                return true;
            };
            return false;
        }

       

        public IEnumerable<Book> GetAllBooks()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.ToList();
            }
            return null;
        }

        public Author GetAuthor(int id)
        {
            Author result;
            using (var db = new LibraryContext())
            {
                throw new NotImplementedException(); //TODO: Remove this line and add code                
            };
            return result;
        }

        public Book GetBook(int id)
        {
            Book result;
            using (var db = new LibraryContext())
            {
                throw new NotImplementedException(); //TODO: Remove this line and add code              
            };
            return result;
        }

        public bool UpdateAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                throw new NotImplementedException(); //TODO: Remove this line and add code
                return true;
            };
            return false;
        }

        public bool UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                throw new NotImplementedException(); //TODO: Remove this line and add code
                return true;
            };
            return false;
        }
    }
}
