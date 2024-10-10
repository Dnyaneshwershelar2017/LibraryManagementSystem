namespace LibraryManagementSystem.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public TransactionType TransactionType { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public enum TransactionType
    {
        Issue,
        Return
    }

}
