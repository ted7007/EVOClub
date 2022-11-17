/*
      Задача: 
      Есть студенты с следующей информацией:
      ФИ
      Возраст
      Рейтинг успеваемости
      
      Необходимо запросить у пользователя 3 студента.
       Вывести их информацию в табличном виде, затем вывести студента с лучшей успеваемостью

*/     

 // Запрос студентов
string[][] students = new string[3][];
for (int i = 0; i < 3; i++)
{
    students[i] = GetStudent();
}
PrintStudents(students);

var maxStudent = SearchMaxRating(students);
string[][] maxstudentInArray = {
    maxStudent
};
Console.WriteLine("Лучший ученик:");
PrintStudents(maxstudentInArray);



string[] SearchMaxRating(string[][] students)
{
    float max = 0;
    string[] maxStudent = new string[3];
    for (int i = 0; i < students.GetLength(0); i++)
    {
        var rating = float.Parse(students[i][2]);
        if (rating > max)
        {
            max = rating;
            maxStudent = students[i];
        } 
    }

    return maxStudent;
}
void PrintStudents(string[][] students)
{
    if (students is null)
        throw new ArgumentNullException(nameof(students));
    Console.WriteLine($"{"ФИ",-12}{"Возраст",-12}{"Рейтинг успеваемости",-24}");
    for (int i = 0; i < students.GetLength(0); i++)
    {
         Console.WriteLine($"{students[i][0],-12}{students[i][1],-12}{students[i][2],-24}");
    }
}

string[] GetStudent()
{
    string[] student = new string[3];
    student[0] = GetResponse("ФИ");
    student[1] = GetResponse("Возраст");
    student[2] = GetResponse("Рейтинг успеваемости");
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