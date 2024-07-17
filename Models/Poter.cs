using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Primitives;

namespace Yt_Dot6Identity.Models
{
    public class Poter
    {
        [Key]
        public int PoterId { get; set; }    
        public string PoterFname { get; set; }  
        public string PoterLname { get; set; }
        public string Position { get; set; }
    }
}