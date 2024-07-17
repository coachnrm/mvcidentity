
using System.ComponentModel.DataAnnotations;

namespace Yt_Dot6Identity.Models
{
    public class Urgent
    {
        [Key]
        public int UrgentId { get; set; }
        public string   UrgentType { get; set;}    
    }
}