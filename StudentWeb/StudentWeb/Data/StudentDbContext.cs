namespace StudentWeb.Data
{
    using StudentWeb.Data.Models;
    using Microsoft.EntityFrameworkCore;
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) 
            : base(options)
        {

        }
        DbSet<Student> Students { get; set; }
    }
}
