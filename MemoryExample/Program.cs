using MemoryExample;


int number = 1;

int[] array = new int[3];

array[2] = number;



#region Example1

Cat firstCat = new Cat();
firstCat.Name = "Вася";

Cat firstCatOtherVar = firstCat;

Console.WriteLine(firstCat.Name);

Console.WriteLine(firstCatOtherVar.Name);

firstCat.Name = "Игорь";
Console.WriteLine("Васю теперь зовут Игорь.");
Console.WriteLine(firstCat.Name);
Console.WriteLine(firstCatOtherVar.Name);

#endregion

#region Example2
string a = "Tom";

string b = "Mark";

b = a;

b += "ara";

Console.WriteLine(a);

Console.WriteLine(b);
// Почему они отличаются?)
#endregion