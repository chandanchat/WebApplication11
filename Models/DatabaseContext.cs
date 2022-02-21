using Microsoft.EntityFrameworkCore;

namespace WebApplication11.Models
{
    public class DatabaseContext:DbContext 
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }  
        public DbSet<EmpTable>EmpTables { get; set; }
    }
}
