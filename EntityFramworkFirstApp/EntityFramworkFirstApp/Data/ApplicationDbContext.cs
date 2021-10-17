using EntityFramworkFirstApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace EntityFramworkFirstApp.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser,IdentityRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Student> StudentRecords { get; set; }
        public DbSet<Section> SectionRecords { get; set; }
        public DbSet<Semester> Semesters { get; set; }
    }
}
