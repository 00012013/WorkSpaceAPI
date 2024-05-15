using Microsoft.EntityFrameworkCore;
using WorkSpaceAPI.Model;

namespace WorkSpaceAPI.DBContexts
{
    public class AppContexts : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public AppContexts(DbContextOptions<AppContexts> dbContext):base(dbContext) { 
        }
    }
}
