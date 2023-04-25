using Students;

var teacher = new Teacher("Andrey", "Starinin", new DateTime(1986, 2, 18), "IT", "SoftDev");
var students = new Student[]
{
    new Student("Student 1", "Students", new DateTime(2020, 1, 1), "IT", "G101"),
    new Student("Student 2", "Students", new DateTime(2020, 1, 1), "IT", "G101"),
    new Student("Student 3", "Students", new DateTime(2020, 1, 1), "IT", "G101"),
};

teacher.Teach(students);

foreach (var student in students)
{
    student.Study(teacher);
}