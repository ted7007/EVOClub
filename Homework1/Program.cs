
Console.WriteLine("Укажите любое целое число, которое будет являться максимальным числов в игре (число должно привышать 0) ");
int maxNumber = -1;
do
{
    string maxNumberStr = Console.ReadLine();
    maxNumber = int.Parse(maxNumberStr);         // по хорошему использовать tryParse, но я её не показывал
    if (maxNumber <= 0)
        Console.WriteLine("Неверный ввод.");
}
while (maxNumber <= 0);

Console.WriteLine($"И так, вы загадали число {maxNumber}." +
                  $" Это число будет являться максимально допустимым диапозоном в этой игре, минимальным же числом является 0." +
                  $" Суть игры: вам предстоит угадать случайно загаданное число на промежутке от 0 до {maxNumber}. " +
                  $"В случае неудачи программа сообщит о том, загаданное число больше или меньше." +
                  $" В случае правильного ответа - игра завершится." +
                  $" Если играть надоело, то вместо ввода числа отставьте пустое поле и нажмите enter. Удачи!");
Random rnd = new Random();
int randomNumber = rnd.Next(0, maxNumber);
int inputNumber = -1;
bool isExit = false;    // флаг(индикатор), означающий выход из игры
do
{
    Console.WriteLine("Попробуйте угадать число!");
    string input = Console.ReadLine();  // Вводим ответ
    if (string.IsNullOrEmpty(input))     // Проверяем на пустоту,
    // if(input == "") - тоже правильный вариант, "" это пустая строка
    {
        isExit = true;
        Console.WriteLine($"Игра окончена. Вы ввели пустую строку, загаданное число было {randomNumber}.");
    }
    else
        inputNumber = int.Parse(input);         // Конвертируем в число
    if (inputNumber == randomNumber && !isExit)  // Проверяем на победу, добавляем условие того что пользователь не вышел из игры
    {
        Console.WriteLine($"Отлично, вы победили! Это действительно число {randomNumber}");
        isExit = true;
    }
    else if (inputNumber < randomNumber && !isExit)
        Console.WriteLine("Введенное число меньше загаданного.");
    else if (!isExit)
        Console.WriteLine("Введенное число больше загаданного.");
}
while (!isExit);   // пока НЕ выход




#region Другой вариант, с break:

//do
//{
//    Console.WriteLine("Попробуйте угадать число!");
//    string input = Console.ReadLine(); 
//    if (input == "")    
//    {
//        Console.WriteLine($"Игра окончена. Вы ввели пустую строку, загаданное число было {randomNumber}.");
//        break;
//    }
//    inputNumber = int.Parse(input);
//    if (inputNumber == randomNumber && !isExit)
//    {
//        Console.WriteLine($"Отлично, вы победили! Это действительно число {randomNumber}");
//        break;
//    }
//    else if (inputNumber < randomNumber )
//        Console.WriteLine("Введенное число меньше загаданного.");
//    else 
//        Console.WriteLine("Введенное число больше загаданного.");
//}
//while (true);

#endregion