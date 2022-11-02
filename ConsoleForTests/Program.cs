Console.WriteLine("Goodbye World!!!"); //1 Задание 

Console.Write("Hello" + " " + "World!!!\n"); //2 Задание 

Console.Write("Hello" + " " + "World!!! \nBye!\n"); //2 Задание под звёздочкой (надеюсь правильно понял смысл задания)

string fullName = "Кисленко Алексей Юрьевич";
int old = 18;
string number = "+7 (914) 123-123-21";
string email = "test@joy.ty";
int resultMath = 72;
Console.WriteLine($"ФИО участника: {fullName}\nВозраст: {old}\nНомер телефона: {number}\nАдрес электронной почты: {email}\nРезультаты ЕГЭ по математика(профиль): {resultMath}");

Console.WriteLine("Укажите любое целое число, которое будет являться максимальным числов в игре (число должно привышать 0) ");
string userNumber = Console.ReadLine();   // userNumber хрнаит строку, а в названии число?  userNumberStr/userInput было бы лучше 
int userNumber1 = Int32.Parse(userNumber);// Сюда userNumber уже подходит, "1" ни к чему. Я бы назвал "maxNumber".

while (userNumber1 <= 0)
{
    Console.WriteLine("Введите число привышающее 0");
    userNumber = Console.ReadLine();
    userNumber1 = Int32.Parse(userNumber);
}
// Длинная строка кода. Когда нужно использовать слайдер для чтения - неудобно читать. 
Console.WriteLine($"И так, вы загадали число {userNumber}. Это число будет являться максимально допустимым диапозоном в этой игре, минимальным же числом является 0. Суть игры: вам предстоит угадать случайно загаданное число на промежутке от 0 до {userNumber}. В случае неудачи программа сообщит о том, загаданное число больше или меньше. В случае правильного ответа - игра завершится. Если играть надоело, то вместо ввода числа отставьте пустое поле и нажмите enter. Удачи!");

// Как можно было бы сделать:
Console.WriteLine($"И так, вы загадали число {userNumber}." +
                  $" Это число будет являться максимально допустимым диапозоном в этой игре, минимальным же числом является 0." +
                  $" Суть игры: вам предстоит угадать случайно загаданное число на промежутке от 0 до {userNumber}. " +
                  $"В случае неудачи программа сообщит о том, загаданное число больше или меньше." +
                  $" В случае правильного ответа - игра завершится." +
                  $" Если играть надоело, то вместо ввода числа отставьте пустое поле и нажмите enter. Удачи!");

Random rnd = new Random();
int value = rnd.Next(0, userNumber1);           // randomNumber например?
int option = Int32.Parse(Console.ReadLine());   // optionNumber? 
while (option != value)
{
    if (option > value)
    {
        Console.WriteLine("Ваш вариант больше, чем загаданное число");
    }
    else
    {
        Console.WriteLine("Ваш вариант меньше, чем загаданное число");
    }
    option = Int32.Parse(Console.ReadLine()); //  самое интересное - после путсого ввода действительно игра завершается xD, выкидывается ошибка
}
if (option == value)
{
    Console.WriteLine("Поздравляю, вы победили!");
}
//У меня не вышло реализовать выход из игры(((
//Здесь удобно использовать break:
while (option != value)
{
    if (option > value)
    {
        Console.WriteLine("Ваш вариант больше, чем загаданное число");
    }
    else
    {
        Console.WriteLine("Ваш вариант меньше, чем загаданное число");
    }
    var input = Console.ReadLine();
    if (input == "")
        break;
    option = Int32.Parse(input);
}
