namespace HealthClinic.Domain.Models;

public class Person
{
    public Person(string firstName, string lastName)
    {
        Id = default;
        FirstName = firstName;
        LastName = lastName;
    }
    
    public int Id { get; }

    public string FirstName { get; }
    public string LastName { get; }
}