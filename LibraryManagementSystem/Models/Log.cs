using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Log
    {
        public int LogId { get; set; }

        public string? UserId { get; set; } // Nullable for system actions
        public virtual User User { get; set; }

        [Required]
        public string Action { get; set; }

        public DateTime LogDate { get; set; } = DateTime.UtcNow;

        public string Details { get; set; }
    }

}
