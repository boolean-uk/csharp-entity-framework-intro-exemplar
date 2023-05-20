using ef.intro.wwwapi.Models;

namespace ef.intro.wwwapi.Repository
{
    public interface ILibraryRepository
    {
        Author GetAuthor(int id);
        bool AddAuthor(Author author);
        IEnumerable<Author> GetAllAuthors();
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(int id);


        Book GetBook(int id);
        bool AddBook(Book book);
        IEnumerable<Book> GetAllBooks();
        bool UpdateBook(Book book);
        bool DeleteBook(int id);


    }
}
