using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public int CategoryId { get; set; }
        public  Category Category { get; set; }

        public int AuthorId { get; set; }
        public  Author Author { get; set; }

        [Required]
        public string ISBN { get; set; }

        public int PublishedYear { get; set; }

        public int StockQuantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public  ICollection<BookRequest> BookRequests { get; set; }
        public  ICollection<IssuedBook> IssuedBooks { get; set; }
        public  ICollection<Transaction> Transactions { get; set; }
    }

}
