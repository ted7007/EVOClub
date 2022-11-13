
#region Theory
/* SRP - Single Responsibility Principle
 * DRY - Don't Repeat Yourself
 */

#endregion

#region Exercise 1
/*
  Составить программу для графического изображения делимости чисел от 1 до n(значение n вводится с клавиатуры).
  В каждой строке надо напечатать очередное число и столько символов «+»,
  сколько делителей у этого числа. Например, если n = 4, то на экране должно быть напечатано:
1+
2++
3++
4+++
*/


int start = 1;
int end = 0;

Console.WriteLine("Введите верхнюю границу чисел для графического изображения делимости.");

//Ввод границы с консоли
end = GetNumberFromConsole();


for (int i = start; i <= end; i++)
{
     WriteNumberWithDivisors(i);
}

int GetCountDivisors(int number)
{
    int countDivisors = 0;
    for (int j = 1; j <= number; j++)            // Вычисление количества делителей для каждого числа
    {
        if (number % j == 0)
            countDivisors++;
    }

    return countDivisors;
}

string GetStringOfNumberWithPluses(int number, int countPluses)
{
    string result = "";                     // Вывод числа и кол-ва делителей, в формате плюсов
    result += Convert.ToString(number);       //4

    for (int j = 0; j < countPluses; j++)
        result += "+";                        //4+++
    result += "\n";
    return result;
}

void WriteNumberWithDivisors(int number)
{
    int countDivisors = GetCountDivisors(number);

    string stringOfNumberWithPluses = GetStringOfNumberWithPluses(number, countDivisors);
    Console.WriteLine(stringOfNumberWithPluses);
}

int GetNumberFromConsole()
{
    int end;
    var input = Console.ReadLine();
    if (!Int32.TryParse(input, out end)) // Валидация ввода
    {
        Console.WriteLine("Верхняя граница должна быть целым числом.");
        return 0;
    }

    return end;
}
#region answer
/*
 * 1 - выделить 2 метода под вычисление кол-ва делителей и под вывод делителей 
 * 2 - выделить 3й метод под полную задачу, если она может вызываться несколько раз
 */
#endregion

#endregion
