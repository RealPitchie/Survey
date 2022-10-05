using Microsoft.EntityFrameworkCore;
using Survey.Application.Interfaces;

namespace Survey.Persistence;

public class SurveyRepository : ISurveyRepository
{
    private DataContext _context;

    public SurveyRepository(DataContext context)
    {
        _context = context;
    }
    public async Task AddSurvey(Domain.Models.Survey survey)
    {
        throw new NotImplementedException();
    }

    public async Task EditSurvey(Domain.Models.Survey survey)
    {
        throw new NotImplementedException();
    }

    public async Task RemoveSurvey(Domain.Models.Survey survey)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Domain.Models.Survey>> GetAllSurveysAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Domain.Models.Survey> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
}