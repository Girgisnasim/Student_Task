using Microsoft.EntityFrameworkCore;

namespace Student_Task.Models
{
    public class studentDb:DbContext
    {
        public studentDb(DbContextOptions<studentDb> options):base(options) { 
        
        
        }

        public DbSet<Student> Students { get; set; }


    }
}
