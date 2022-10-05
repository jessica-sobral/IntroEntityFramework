using Microsoft.EntityFrameworkCore;

namespace IntroEntityFramework.Models;

public class SystemContext : DbContext
{
    public DbSet<Computer> Computers { get; set; }

    public SystemContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(
            "server=localhost;database=estudante;user=estudante;password=estudante;"
        );
    }
}