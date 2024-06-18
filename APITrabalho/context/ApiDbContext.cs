using Microsoft.EntityFrameworkCore;
using APITrabalho.Models;

namespace APITrabalho.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task>()
                .HasKey(t => t.Id); 

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id); 
            
            modelBuilder.Entity<Task>()
                .HasOne(t => t.User)     
                .WithMany(u => u.Tasks)  
                .HasForeignKey(t => t.UserId)  
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
