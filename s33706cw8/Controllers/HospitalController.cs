using Microsoft.AspNetCore.Mvc;
using s33706cw8.Exceptions;
using s33706cw8.Services;

namespace s33706cw8.Controllers;

[ApiController]
[Route("api/patients")]
public class HospitalController : ControllerBase
{
    private readonly IDbService _dbService;
    
    public HospitalController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpGet]
    public async Task<object> GetPatients()
    {
        try
        {
            var patients = await _dbService.GetPatients();
            return Ok(patients);
        }
        catch (NotFoundException e)
        {
            return NotFound();
        }
    }
}