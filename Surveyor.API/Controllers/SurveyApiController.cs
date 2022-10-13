using Microsoft.AspNetCore.Mvc;
using Surveyor.Persistence;

namespace Surveyor.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SurveyApiController : ControllerBase
{
     private readonly SurveyRepository _repo;

     public SurveyApiController(SurveyRepository repo)
     {
          _repo = repo;
     }

     [HttpGet]
     public async Task<IEnumerable<Domain.Models.Survey>> GetSurveys()
     {
          return await _repo.GetAllSurveysAsync();
     }
     
}