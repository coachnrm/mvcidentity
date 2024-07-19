using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Yt_Dot6Identity.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        // public object NurseRequests { get; internal set; }
        public DbSet<Department> Departments {get; set;}
        public DbSet<JobStatus> JobStatuses {get; set;}
        public DbSet<Material> Materials {get; set;}
        public DbSet<MaterialStatus> MaterialStatuses {get; set;}
        public DbSet<NurseRequest> NurseRequest {get; set;}
        public DbSet<Patient> Patients {get; set;}
        public DbSet<Poter> Poters {get; set;}
        public DbSet<Urgent> Urgents {get; set;}
        public DbSet<UserLogin> UserLogins {get; set;}
        public DbSet<UserRole> UserRoles {get; set;}
    }
}
