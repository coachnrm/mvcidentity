using System.ComponentModel.DataAnnotations;

namespace Yt_Dot6Identity.Models
{
    public class MaterialStatus
    {
        [Key]
        public int MatStatusId { get; set; } 
        public string MatStatusName { get; set; }

    }
}