namespace Surveyor.Domain.Models;

public class SurveyResult
{
    public string Id { get; set; }
    public List<Answer> Answers { get; set; }
    public DateTime PassedOn { get; set; }

    public SurveyResult()
    {
        Id = Guid.NewGuid().ToString();
        PassedOn = DateTime.Now;
        Answers = new List<Answer>();
    }
}