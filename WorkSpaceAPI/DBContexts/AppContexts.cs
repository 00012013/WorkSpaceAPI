using Microsoft.EntityFrameworkCore;
using WorkSpaceAPI.Model;

namespace WorkSpaceAPI.DBContexts
{
    public class AppContexts : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public AppContexts(DbContextOptions<AppContexts> dbContext) : base(dbContext)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(e => e.Department).WithMany(d => d.Employees).HasForeignKey(e => e.DepartmentId).OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
