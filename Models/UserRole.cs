using System.ComponentModel.DataAnnotations;

namespace Yt_Dot6Identity.Models
{
    public class UserRole
    {
        [Key]
        public int RoldId { get; set; } 
        public string Role { get; set; }
    }
}