using Surveyor.Domain.Models;

namespace Surveyor.Application.Interfaces;

public interface ISurveyRepository
{
    Task AddSurvey(Survey survey);
    Task EditSurvey(Survey survey);
    Task RemoveSurvey(Survey survey);
    Task<List<Survey>> GetAllSurveysAsync();
    Task<Survey?> GetByIdAsync(string id);
}