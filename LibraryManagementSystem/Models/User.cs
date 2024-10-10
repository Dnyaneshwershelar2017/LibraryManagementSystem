using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public UserRole Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ICollection<BookRequest> BookRequests { get; set; }
        public virtual ICollection<IssuedBook> IssuedBooks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

    }

    public enum UserRole
    {
        Admin,
        Student
    }

}
