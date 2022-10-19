namespace Surveyor.Domain.Models;

public class Answer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Value { get; set; } = "";
}