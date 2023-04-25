namespace Students;

public class Teacher : Person
{
    private readonly string _faculty;
    private readonly string _department;
    
    public Teacher(string firstName, string lastName, DateTime dateOfBirth, string faculty, string department) 
        : base(firstName, lastName, dateOfBirth)
    {
        _faculty = faculty;
        _department = department;
    }

    public void Teach(Student[] students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Учу {student.GetFullName()}");
        }
    }

    public string GetFaculty()
    {
        return _faculty;
    }
    
    public string GetDepartment()
    {
        return _department;
    }
}