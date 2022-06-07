namespace HealthClinic.WebApi.Models;

public class CreatePersonRequest
{
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public string FirstName { get; init; } = null!;
    
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public string LastName { get; init; } = null!;
}