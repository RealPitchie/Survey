namespace Surveyor.Persistence.Services;

public class SurveyService
{
    private readonly SurveyRepository _repo;

    public SurveyService(SurveyRepository repo)
    {
        _repo = repo;
    } 
}