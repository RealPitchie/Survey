namespace Survey.Domain.Models;
#nullable disable
public class SurveyItem
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public virtual ICollection<SurveyItemOption> Options { get; set; }
}