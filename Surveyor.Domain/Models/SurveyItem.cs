namespace Surveyor.Domain.Models;
#nullable disable
public class SurveyItem
{
    public string Id { get; set; }
    public string Name { get; set; }
    public ItemType Type { get; set; }
    public string Options { get; set; }
}

public enum ItemType
{ 
    Text, 
    List,
    YesNo
}