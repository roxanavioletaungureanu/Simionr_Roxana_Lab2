using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Simionr_Roxana_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Book Title")]
        public string Author { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]

        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
