using Microsoft.EntityFrameworkCore;
using Surveyor.Application.Interfaces;
using Surveyor.Domain.Models;

namespace Surveyor.Persistence;
#nullable disable
public class SurveyRepository : ISurveyRepository
{
    private DataContext _context;

    public SurveyRepository(DataContext context)
    {
        _context = context;
    }
    public async Task AddSurvey(Survey survey)
    {
        await _context.AddAsync(survey);
        await _context.SaveChangesAsync();
    }

    public async Task EditSurvey(Survey survey)
    {
        _context.Update(survey);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveSurvey(Survey survey)
    {
        _context.Remove(survey);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Survey>> GetAllSurveysAsync()
    {
        return await _context.Surveys
            .Include(s => s.Items)
            .Include(s => s.Results)
            .ThenInclude(r => r.Answers)
            .ToListAsync();
    }

    public async Task<Survey> GetByIdAsync(string id)
    { 
        return await _context.Surveys
            .Include(s => s.Items)
            .Include(s => s.Results)
            .ThenInclude(r => r.Answers)
            .AsSplitQuery()
            .FirstOrDefaultAsync(s => s.Id == id);
    }
    #region Results Stuff
    public async Task<Survey> GetResultsBySurveyIdAsync(string targetId)
    {
        return await _context.Surveys
            .Include(s => s.Results)
            .ThenInclude(r => r.Answers)
            .FirstOrDefaultAsync(s => s.Id == targetId);
    }

    public async Task SaveResultsAsync(Survey survey)
    {
        RemoveEmptyEntries(survey);
        _context.Update(survey);
        await _context.SaveChangesAsync();
    }
    #endregion

    private void RemoveEmptyEntries(Survey survey)
    {
        survey.Results.RemoveAll(r => r.Answers.Count == 0);
    }

}