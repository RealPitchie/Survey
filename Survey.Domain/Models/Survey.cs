namespace Survey.Domain.Models;
#nullable disable
public class Survey
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public DateTime CreatedAt { get; set; }
    public virtual ICollection<SurveyItem> Items { get; set; }
}