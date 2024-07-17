using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace Yt_Dot6Identity.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; } 
        public string MaterialType { get; set; }
        public int QtyFree { get; set; }    
        public int QtyUsed { get; set; }    
        public string MatStatusName { get; set; }
    }
}