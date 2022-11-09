
/*
 Описание метода:
[модификаторы] тип_возвращаемого_значения название_метода ([параметры])
{
    // тело метода
}

Модификаторы и параметры необязательны.     

тип возвращаемого значения - int, string, char...
                             пользовательские типы,
                             void                            
параметры - аргументы/переменные, которые будут передаваться для использования внутри метода

Вызов метода:
имя_метода([значения параметров]) 
*/


/*
 Примерное описание метода WriteLine:
 static void WriteLine(string text)
 {
    //... тело программы, которое производит вывод текста в консоль
 }
 */

using System.Threading.Channels;

Console.WriteLine("bye programs in main :(");



#region  examples without return

// void SayHello()
// {
//     Console.WriteLine("Hello");
// }
//
// SayHello();
//
// void PrintMessage(string message)
// {
//     Console.WriteLine(message);
// }
// // PrintMessage(10);
// // PrintMessage($"{SayHello()} Functional programming");
//    PrintMessage($"Hello functional programming");
//
// void Sum(int x, int y)
// {
//     int result = x + y;
//     Console.WriteLine($"{x} + {y} = {result}");
// }
// //  Sum(10, "1327");
//     Sum(10, 1327);
//
// void PrintPerson(string name, int age = 1, string company = "Undefined")
// {
//     Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
// }
// //PrintPerson(18);
// PrintPerson("Alex");
// PrintPerson("Alex", 20);
// PrintPerson("Alex", company:"Google");
// PrintPerson("Alex", 20, "Google");
#endregion

#region examples with return
//
// string GetMessage()
// {
//     return "Hello";
// }
//
// string getMessageRes = GetMessage();
// /*
// string GetMessage2()
// {
//     Console.WriteLine("Hello");
// }
//
// string GetMessage3()
// {
//     return 3;   /
// }
// */
// int Sum(int x, int y)
// {
//     return x + y;
// }
//
// var sumResult = Sum(2, 225);
//
// void PrintPerson(string name, int age)
// {
//     if(age > 120 || age < 1)
//     {
//         Console.WriteLine("Недопустимый возраст");
//         return;        // аналогия break
//     }
//     Console.WriteLine($"Имя: {name}  Возраст: {age}");
// }
//
// PrintPerson("Vasya", 18);
// PrintPerson("Anonimus", 999);

#endregion

#region Example with reference , out argument
//                                refs:
// void Increment(int n)
// {
//     n++;
//     Console.WriteLine($"Число в методе Increment: {n}");
// }
//  
// int number = 5;
// Console.WriteLine($"Число до метода Increment: {number}");
// Increment(number);
// Console.WriteLine($"Число после метода Increment: {number}");
//
// void Increment(ref int n)
// {
//     n++;
//     Console.WriteLine($"Число в методе Increment: {n}");
// }
//  
// int number = 5;
// Console.WriteLine($"Число до метода Increment: {number}");
// Increment(ref number);
// Console.WriteLine($"Число после метода Increment: {number}");
//                              out: 
// int result = 0;
// bool isSucces = int.TryParse("10", out result);
// Console.WriteLine(result); // 10
// Console.WriteLine(isSucces); // true
// void Sum(int x, int y, out int result)
// {
//     result = x + y;
// }
//  
// int number;
//  
// Sum(10, 15, out number);
//  
// Console.WriteLine(number);   // 25
// // Можно использовать несколько out.
//
// void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
// {
//     rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
//     rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
// }
//


#endregion

#region Example with param

// int Sum(params int[] summands)
// {
//     int result = 0;
//     foreach (var i in summands)
//         result += i;
//     return result;
// }
//
// Sum(1, 2, 4);
// Sum(new int[] { 1, 5, 7, 10 });
// Console.WriteLine(Sum());

#endregion

#region Example with recursion

// long GetFactorial(long n)
// {
//     if (n == 1 || n == 0)
//         return 1;
//     return n * GetFactorial(n - 1);
// }
//
// GetFactorial(4); // посмотреть в дебаге

#endregion
