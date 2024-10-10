namespace LibraryManagementSystem.Models
{
    public class IssuedBook
    {
        public int IssuedBookId { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

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
