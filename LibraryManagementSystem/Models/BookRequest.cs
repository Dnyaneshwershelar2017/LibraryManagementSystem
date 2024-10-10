namespace LibraryManagementSystem.Models
{
    public class BookRequest
    {
        public int BookRequestId { get; set; }

        // Change UserId to string
        public string UserId { get; set; }
        public User User { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public DateTime RequestDate { get; set; } = DateTime.UtcNow;

        public RequestStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

    public enum RequestStatus
    {
        Pending,
        Approved,
        Rejected
    }

}
