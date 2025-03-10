using _6th_Sem_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace _6th_Sem_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentAccount> StudentAccounts { get; set; }
    }
}
