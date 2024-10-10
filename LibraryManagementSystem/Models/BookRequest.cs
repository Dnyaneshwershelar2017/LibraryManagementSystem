namespace LibraryManagementSystem.Models
{
    public class BookRequest
    {
        public int BookRequestId { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

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
