using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Setting
    {
        public int SettingId { get; set; }

        [Required]
        public string SettingKey { get; set; }

        [Required]
        public string SettingValue { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

}
