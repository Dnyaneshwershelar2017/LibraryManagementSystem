using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class User: IdentityUser
    {
        public UserRole Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ICollection<BookRequest> BookRequests { get; set; }
        public virtual ICollection<IssuedBook> IssuedBooks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

        public User()
        {
            BookRequests = new List<BookRequest>();
            IssuedBooks = new List<IssuedBook>();
            Transactions = new List<Transaction>();
        }

    }

    public enum UserRole
    {
        Admin,
        Student
    }

}
