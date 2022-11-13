// Комментарии:
// - однострочный комментарий



/*

многострочный комментарий

*/


//Преобразования:


#region  Расширяющие(неявные), выполняются компилятором

byte byteA = 3;

int intA = byteA;

float floatA = intA;

long longA = intA;

long longMax = long.MaxValue;

float longMaxInFloat = longMax;

Console.WriteLine($"byteA = {byteA}\nlongA from byte = {longA}\nfloatA from byte: {floatA}");

Console.WriteLine($"max long = {longMax}\nmax Long in float = {longMaxInFloat}");

#endregion

#region      Сужающие(явные), выполняются в ручную

//long longA = 3;
////byte byteA = longA;
//byte byteA = (byte)longA;

//Console.WriteLine($"longA that can be byte = {longA}\nlongA in byte = {byteA}");

//longA = 257;                                         //...000100000001
//byteA = (byte)longA;    //обрезает, оставляет 8 бит           00000001

//Console.WriteLine($"longA that can't be byte = {longA}\nlongA in byte = {byteA}");
////byteA = checked((byte)longA); - throws exception


#endregion


#region Преобразования используя статические классы примитивных типов

//// Все примитивные типы имеют два метода,
//// которые позволяют преобразовать строку к данному типу.
//// Это методы Parse() и TryParse()

//string tenStr = "10";
//int tenInt = int.Parse(tenStr);

//string doubleStr = "10,54";
//double doubleFromStr = double.Parse(doubleStr);

//Console.WriteLine($"tenStr = {tenStr}\ntenInt = {tenInt}\ndoubleStr = {doubleStr}\ndouble from str = {doubleFromStr}");

////Ошибка, т.к. невозможно преобразовать в int
////int StrInInt = int.Parse(doubleStr); 

//int strInInt = 0;
//var result = int.TryParse(doubleStr, out strInInt);
//if(result)
//    Console.WriteLine($"{doubleStr} succesfull converted to int; result = {strInInt}");
//else
//    Console.WriteLine($"{doubleStr} can't be converted to int;");

#endregion

#region Преобразования используя статический класс Convert
////В качестве параметра в эти методы может передаваться значение различных примитивных типов,
////необязательно строки:

//int intFromString = Convert.ToInt32("23");

//bool b = true;
//double doubleFrombool = Convert.ToDouble(b);
//Console.WriteLine($"int From String = {intFromString}\ndouble From bool = {doubleFrombool}");

////exception, byty = -127..127
////sbyte byteValue = Convert.ToSByte(128);
#endregion