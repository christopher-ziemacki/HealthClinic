using HealthClinic.Data;
using HealthClinic.Domain.Models;
using HealthClinic.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.WebApi.Controllers;

[ApiController]
[Route("people")]
public class PeopleController : Controller
{
    private readonly HealthClinicDbContext _healthClinicDbContext;

    public PeopleController(HealthClinicDbContext healthClinicDbContext)
    {
        _healthClinicDbContext = healthClinicDbContext;
    }
    
    [HttpGet("{personId:int}")]
    public IActionResult Get(int personId)
    {
        var person = _healthClinicDbContext.People.FirstOrDefault(p => p.Id == personId);

        if (person is null)
        {
            return NotFound();
        }

        var getPersonResponse = new GetPersonResponse
        {
            FirstName = person.FirstName,
            LastName = person.LastName
        };
        
        return Ok(getPersonResponse);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePersonRequest createPersonRequest)
    {
        var person = new Person(createPersonRequest.FirstName, createPersonRequest.LastName);
        
        _healthClinicDbContext.People.Add(person);

        await _healthClinicDbContext.SaveChangesAsync();
        
        return Ok(person.Id);
    }
}