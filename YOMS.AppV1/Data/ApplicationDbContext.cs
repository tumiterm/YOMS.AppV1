using Microsoft.EntityFrameworkCore;
using YOMS.AppV1.Models;

namespace YOMS.AppV1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicantProfile> Profiles { get; set; }   
    }
}
