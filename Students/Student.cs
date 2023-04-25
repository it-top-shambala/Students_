namespace Students;

public class Student : Person
{
    private readonly string _faculty;
    private readonly string _group;

    public Student(string firstName, string lastName, DateTime dateOfBirth, string faculty, string group) 
        : base(firstName, lastName, dateOfBirth)
    {
        _faculty = faculty;
        _group = group;
    }

    public void Study(Teacher teacher)
    {
        Console.WriteLine($"Учусь у {teacher.GetFullName()}");
    }
    
    public string GetFaculty()
    {
        return _faculty;
    }
    
    public string GetGroup()
    {
        return _group;
    }
}