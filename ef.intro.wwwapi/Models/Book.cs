using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ef.intro.wwwapi.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        
        [Key, ForeignKey("Author")]
        public int AuthorId { get; set; }        
        public Author Author { get; set; }
    }
}