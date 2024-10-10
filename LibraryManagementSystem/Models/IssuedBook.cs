namespace LibraryManagementSystem.Models
{
    public class IssuedBook
    {
        public int IssuedBookId { get; set; }

        public string UserId { get; set; }
        public  User User { get; set; }

        public int BookId { get; set; }
        public  Book Book { get; set; }

        public DateTime IssuedDate { get; set; } = DateTime.UtcNow;

        public DateTime? ReturnDate { get; set; }

        public BookStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

    public enum BookStatus
    {
        Issued,
        Returned,
        Overdue
    }

}
