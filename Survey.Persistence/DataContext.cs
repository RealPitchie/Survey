using Microsoft.EntityFrameworkCore; 
using Survey.Domain.Models;

#nullable disable
namespace Survey.Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                .UseNpgsql("UserID=root;Password=passmein123;Server=localhost;Port=5432;Database=survey;");
        }

    }
    public DbSet<Domain.Models.Survey> Surveys { get; set; }
}
