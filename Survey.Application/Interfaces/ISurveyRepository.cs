namespace Survey.Application.Interfaces;

public interface ISurveyRepository
{
    Task AddSurvey(Domain.Models.Survey survey);
    Task EditSurvey(Domain.Models.Survey survey);
    Task RemoveSurvey(Domain.Models.Survey survey);
    Task<IEnumerable<Domain.Models.Survey>> GetAllSurveysAsync();
    Task<Domain.Models.Survey?> GetByIdAsync(string id);
}