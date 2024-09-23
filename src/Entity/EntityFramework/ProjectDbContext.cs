using Entity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Entity.EntityFramework;

public class ProjectDbContext : DbContext
{

    private readonly IConfiguration _configuration;

    public ProjectDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (optionsBuilder.IsConfigured)
        {
            return;
        }

        var connectionString = _configuration.GetConnectionString("Default");

        optionsBuilder.UseSqlServer(connectionString, sqlServerOptions => sqlServerOptions.EnableRetryOnFailure())
                      .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
                             Microsoft.Extensions.Logging.LogLevel.Information)
                      .EnableSensitiveDataLogging();

    }

    public DbSet<Employee> Employee { get; set; }

    public DbSet<Position> Position { get; set; }

    public DbSet<Model.Task> Task { get; set; }

    public DbSet<TaskEmployee> TaskEmployee { get; set; }

    public DbSet<Model.TaskStatus> TaskStatus { get; set; }

    public DbSet<Category> Category { get; set; }

    public DbSet<City> City { get; set; }

    public DbSet<Company> Company { get; set; }

}