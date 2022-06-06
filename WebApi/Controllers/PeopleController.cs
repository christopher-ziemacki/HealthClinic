using HealthClinic.Data;
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
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}