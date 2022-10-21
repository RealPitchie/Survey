using Microsoft.EntityFrameworkCore; 
using Surveyor.Domain.Models;

#nullable disable
namespace Surveyor.Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options ) : base(options)
    { 
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                .UseNpgsql("UserID=root;Password=passmein123;Server=localhost;Port=5432;Database=survey;");
        }

    }
    public DbSet<Survey> Surveys { get; set;  }
    public DbSet<SurveyResult> Results { get; set; }
}
