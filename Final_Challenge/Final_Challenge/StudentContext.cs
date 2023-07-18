using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=StudentDatabase;Trusted_Connection=True;\");
    }
}
