namespace Students;

public abstract class Person
{
    private readonly string _firstName;
    private readonly string _lastName;
    private readonly DateTime _dateOfBirth;
    
    protected Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }

    public string GetFirstName()
    {
        return _firstName;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public string GetFullName()
    {
        return $"{_lastName} {_firstName}";
    }

    public DateTime GetDateOfBirth()
    {
        return _dateOfBirth;
    }
}