using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Primitives;

namespace Yt_Dot6Identity.Models;

public class NurseRequest
{
    
    [Key]
    public int  JobId   { get; set; }
    public DateTime ReqDate { get; set; }   
    public DateTime ReqTime { get; set; }
    public DateTime EndDate { get; set; }   
    public DateTime EndTime { get; set; }   
    public int UserId { get; set; } 
    public string Department { get; set; } = null!;
    public string StartPoint { get; set; }  = null!;
    public string EndPoint { get; set; }    = null!;
    public string MaterialType { get; set; } = null!;   
    public string UrentType { get; set; }   = null!;
    public string PatientType { get; set; } = null!;
    public string PoterFname { get; set; }  = null!;
    public string JobStatusName { get; set; } = null!;
    public string Remark { get; set; }  = null!;
    public int QN { get; set; }
    public string QNName { get; set; }  = null!;
    public string QNAge { get; set; }   = null!;
    public string QNSex { get; set; }   = null!;
}
