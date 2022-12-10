


Student[] students = new Student[3];
for (int i = 0; i < 3; i++)
{
    students[i] = GetStudent();
}
PrintStudents(students);

var maxStudent = GetStudentWithMaxRating(students);



Console.WriteLine("Лучший ученик:");
PrintStudent(maxStudent);

Student GetStudentWithMaxRating(Student[] students)
{
    float max = 0;
    Student maxStudent = new Student();
    for (int i = 0; i < students.GetLength(0); i++)
    {
        var rating = students[i].Rating;
        if (rating > max)
        {
            max = rating;
            maxStudent = students[i];
        } 
    }

    return maxStudent;
}

Student GetStudent()
{
    var name = GetResponse("ФИ");
    var ageStr = GetResponse("Возраст");
    var ratingStr = GetResponse("Рейтинг успеваемости");
    Student student = new Student(name, Int32.Parse(ageStr), float.Parse(ratingStr));
    return student;
}

string GetResponse(string request)
{
    Console.WriteLine($"Введите {request}");
    var answer = Console.ReadLine();
    if (answer is null)
        throw new ArgumentNullException(nameof(answer));
    return answer;
}

void PrintStudents(Student[] students)
{
    if (students is null)
        throw new ArgumentNullException(nameof(students));
    Console.WriteLine($"{"ФИ",-12}{"Возраст",-12}{"Рейтинг успеваемости",-24}");
    foreach (var student in students)
    {
        Console.WriteLine($"{student.Name,-12}{student.Age,-12}{student.Rating,-24}");
    }
}

void PrintStudent(Student student)
{
    if (students is null)
        throw new ArgumentNullException(nameof(students));
    Console.WriteLine($"{student.Name,-12}{student.Age,-12}{student.Rating,-24}");
}

struct Student
{
    public string Name;

    public int Age;

    public float Rating;

    public Student(string name, int age, float rating)
    {
        Name = name;
        Age = age;
        Rating = rating;
    }

}