// я не могу рассказать всё :(

// - однострочный комментарий

/* не
   однострочный
   комментарий
*/

#region Переменная

// // тип имя_переменной;
//
// int number;    // определение/объявление переменной (в данном случан number - дефолт значение), под неё выделяется память
// number = 10;   // инициализация переменной, передаем в переменную литерал 10
// number = 15;
// int number2 = 20;

#endregion 

#region data types


/*
 Примитивные типы данных в C#
bool
byte
sbyte
short
ushort
int
uint
long
ulong

float
double
decimal

char

string

object:   
*/
//
// string name = "Tom";
// int age = 33;
// bool isEmployed = false;
// double weight = 78.65;
// char code = 'C';
//
// Console.WriteLine($"Имя: {name}");
// Console.WriteLine($"Возраст: {age}");
// Console.WriteLine($"Вес: {weight}");
// Console.WriteLine($"Работает: {isEmployed}");
// Console.WriteLine($"Код: {code}");
//
// // Неявный тип var:
//
// var hello = "Hell to World";
// int c = 20;
//
// var cancelToken = new CancellationToken();
//
// int numberInInt;
#endregion

// camelCasing

#region Console


// Консольный вывод:
using System.Threading.Channels;

// string hello = "Привет мир";
// Console.WriteLine(hello);
// Console.WriteLine("Добро пожаловать в C#!");
//
// Console.Write("First Line");
// Console.WriteLine("Second line?");

// Вывод переменных:
//
// string name = "Tom";
// int age = 19; // 
// string info = "Name:" + name + " Age:" + age;    // Конкатенация строк Name:Tom Age:19        
// Console.WriteLine(info);                                 
// Console.WriteLine("Name:" + name + " Age:" + age);       
// Console.WriteLine("Name:{0} Age:{1}", name, age);        
// Console.WriteLine($"Name:{name} Age:{age}");             

// Консольный ввод:
//
// string input = Console.ReadLine();
//
// int result = Convert.ToInt32(input);
//
// char symbol = (char)Console.Read();

#endregion

#region Arithmetic

//
// int a = 10;
// int b = 5;
// int c;
// c = a + b;
// c = a - b;
// c = a % b; // остаток 0
// c = a * b;
// c = a / b;   // WARNING
// c = b / a; // ?
// float cFloat;
// cFloat = b / a;
// cFloat = (float)b / a;
// cFloat = b / (float)a;
//
// c = 10;
// a = 5;
// b = 10;
// c += a; // эквивалентно c = c + a;
// c -= b; // эквивалентно c = c - a; c = 5
// c++;    // c = c + 1;
// c--;    // c = c - 1;
//
// a = 5;
// c = ++a; // сначала увеличивает a на 1, затем присваивает рез-т в c
// a = 5;
// c = a++; // сначала присваивает с-шке, затем увеличивает a на 1



#endregion


#region conditionals constructions


int a = 5; 
int b = 7;

bool result;
result = a < b;
result = a == b;
result = (a > b )||( a == 4);
result = (a < b )&& (a == 5);

if (result) 
    Console.WriteLine("result is true yeaaah");
else
    Console.WriteLine("Result is bad(");
if (a < b)
{
    Console.WriteLine("a relly smaller than b!");
    b--;
}
else
  a--;


// Тернарный оператор:

if (a < b)
    b = 10;
else
    b = 0;
a = 11;
b = 10;
b = a < b ? 10 : 0;  // переменная_куда_идет_результат = условие?значение_если_true:значение_если_false

// Конструктор выбора:

if (a == 10)
    b = a;
else if (a == 15)
    b = -10;
else if (a == 14)
    b = 13;
//.....
a = 10;

switch (a)
{
    case 10:
    {
        b = a;
        break;
    }
    case 15:
        b = -10;
        b = 13;
        break;
    case 14:
        b = 13;
        break;
    default:
        Console.WriteLine("a is invalid");
        break;
}

int getAnswer()
{
    return Convert.ToInt32((char)Console.Read());
}

Console.WriteLine("Выберите свой путь: 1 - налево, 2 - прямо, 3 - направо");
switch (Console.Read())
{
    case '1':
        Console.WriteLine("Ты проиграл");
        break;
    case '2':
        Console.WriteLine("Победа! Дверь подарила тебе новую жизнь");
        break;
    case '3':
        Console.WriteLine("Не плохо. Давай дальше! 1 - ...");
        switch (getAnswer())
        {
             case 1:
                 // ..
                 break;
        }
    break;
}


#endregion

Console.ReadKey();