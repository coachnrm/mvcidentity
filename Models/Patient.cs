using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Primitives;

namespace Yt_Dot6Identity.Models
{
    public class Patient
    {
        [Key]
        public int PatienId { get; set; }   
        public string MyProperty { get; set; }
    }
}