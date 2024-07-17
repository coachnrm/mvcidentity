using System.ComponentModel.DataAnnotations;

namespace Yt_Dot6Identity.Models
{
    public class JobStatus
    {
        [Key]
        public int JobStatusId { get; set; }
        public string JobStatusName { get; set; }   
    }
}