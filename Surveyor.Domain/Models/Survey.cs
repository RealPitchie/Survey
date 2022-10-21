namespace Surveyor.Domain.Models;
#nullable disable
public class Survey
{
    public string Id { get; set; }
    public bool IsPublic { get; set; } = true;
    public string Name { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public virtual List<SurveyItem> Items { get; set; }
    public List<SurveyResult> Results { get; set; } = new();
}