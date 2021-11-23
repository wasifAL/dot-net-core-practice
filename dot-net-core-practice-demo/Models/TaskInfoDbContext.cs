using Microsoft.EntityFrameworkCore;


namespace dot_net_core_practice_demo.Models
{
    public class TaskInfoDbContext : DbContext
    {
        public TaskInfoDbContext(DbContextOptions options) : base(options) { }
        DbSet<TaskInfo> Task
        {
            get;
            set;
        }
    }
}
