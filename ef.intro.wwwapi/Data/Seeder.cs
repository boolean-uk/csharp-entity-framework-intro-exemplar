using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ef.intro.wwwapi.Data
{
    public static class Seeder
    {
        private static List<string> Firstnames = new List<string>()
        {
            "Audrey",
            "Donald",
            "Elvis", 
            "Barack",
            "Oprah",
            "Jimi",
            "Mick",
            "Kate",
            "Charles",
            "Kate"
        };
        private static List<string> Lastnames = new List<string>()
        {
            "Hepburn",
            "Trump",
            "Presley",
            "Obama",
            "Winfrey",
            "Hendrix",
            "Jagger",
            "Winslet",
            "Windsor",
            "Middleton"

        };
        private static List<string> Domain = new List<string>()
        {
            "bbc.co.uk",
            "google.com",
            "theworld.ca",
            "something.com",
            "tesla.com",
            "nasa.org.us",
            "gov",
            "gov.gr",
            "gov.nl"
        };

        public static void Seed(this WebApplication app)
        {
         
            
            using (var db = new LibraryContext())
            {
                if (!db.Authors.Any())
                {
                    List<Author> authors = new List<Author>();
                    for(int x = 1; x < 250; x++)
                    {
                        Random random = new Random();                       
                        Author author = new Author();
                        author.Id = x;
                        author.FirstName = Firstnames[random.Next(Firstnames.Count)];
                        author.LastName = Lastnames[random.Next(Lastnames.Count)];
                        author.Email = $"{author.FirstName}.{author.LastName}@{Domain[random.Next(Domain.Count)]}";
                        authors.Add(author);

                                              
                    }
                    db.Authors.AddRange(authors);
                    db.SaveChanges();
                }
                //if (!db.Books.Any())
                //{
                //    var books = new List<Book>()
                //    {
                //        new Book { Id = 1, Title="C# 10", AuthorId=1 },
                //        new Book { Id = 2, Title = "Fundamental of Structured COBOL", AuthorId = 2 },
                //        new Book { Id = 3, Title = "UML", AuthorId = 3 }
                //    };
                //    db.Books.AddRange(books);
                //    db.SaveChanges();
                //}

            }

        }
    }
}



