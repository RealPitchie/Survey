using Microsoft.EntityFrameworkCore;
using Surveyor.Application.Interfaces;

namespace Surveyor.Persistence;

public class SurveyRepository : ISurveyRepository
{
    private DataContext _context;

    public SurveyRepository(DataContext context)
    {
        _context = context;
    }
    public async Task AddSurvey(Domain.Models.Survey survey)
    {
        await _context.AddAsync(survey);
        await _context.SaveChangesAsync();
    }

    public async Task EditSurvey(Domain.Models.Survey survey)
    {
        _context.Update(survey);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveSurvey(Domain.Models.Survey survey)
    {
        _context.Remove(survey);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Domain.Models.Survey>> GetAllSurveysAsync()
    {
        return await _context.Surveys.ToListAsync();
    }

    public async Task<Domain.Models.Survey?> GetByIdAsync(string id)
    { 
        return await _context.Surveys.FirstOrDefaultAsync(s => s.Id == id);
    }
}