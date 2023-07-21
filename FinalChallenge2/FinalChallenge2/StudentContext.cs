using System.Collections.Generic;
using System.Data.Entity;

    public class SchoolContext : DbContext
{
    public SchoolContext() : base()
    {

    }

    public DbSet<Student> Students { get; set; }
    //public DbSet<grade> Grades { get; set; }
}
