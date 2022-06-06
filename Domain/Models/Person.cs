namespace HealthClinic.Domain.Models;

public class Person
{
    public Person(int id, string firstName, string lastName)
    {
        Id = id;
        
        FirstName = firstName;
        LastName = lastName;
    }
    
    public int Id { get; }

    public string FirstName { get; }
    public string LastName { get; }
}