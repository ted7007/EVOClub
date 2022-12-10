using System.Threading.Channels;

#region Theory

/*
   Структуры - механизм в c#, способный объединять в себе состояние и поведение
   Другими словами - используя структуры, мы можем группировать информацию в одном объекте и работать конкретно с объектом
   *Структура отличается от класса тем, как она хранится в памяти!

  Определение структуры:
  struct имя_структуры
  {
        Состояние и поведение структуры
  }
*/

// Состояние, например, банковского счета
string ClientName;
decimal balance;
float depositeRate;

// Поведение такого же банковского счета
void PutOnBalance(decimal sum)
{
    // ..реализация пополнения счета
}

bool TakeFromBalance(decimal sum)
{
    // ..реализация списывания со счета
    return true;
}

// Поле - переменная, которая используется внутри объектов

#endregion

#region Example



 Person Mike = new Person();
 var a = Mike.Age;  




#region Использование полей(каких?)
// // Название_Объекта(экземпляра).Название_Атрибута - вызов атрибута
// var ageOfMike = Mike.age;
// Console.WriteLine($"Person's name: {Mike.name}, Person's age: {ageOfMike}");
//
// Mike.name = "Mike";
// Mike.age = 32;
// Console.WriteLine($"Person's name: {Mike.name}, Person's age: {Mike.age}");

#endregion

#region Использование методов
// Mike.Name = "Mike";
// Mike.Age = 32;
// var lineOfMike = Mike.GetString();
// Console.WriteLine(lineOfMike);

#endregion

#region Использование приватных полей / методов

// Приватные - не в смысле привычной приватности(приватная информация адреса, пароля и тп)!,
// Приватная - недоступная конечному пользователю
// Console.WriteLine($"Person's name: {Mike.name}, Person's age: {ageOfMike}");
// var line = Mike.GetString();

#endregion

#region Конструктор
// /* Конструктор - набор команд, которые вызываются при инициализации(выделении памяти) объекту
//    Конструктор по своей сущности очень похож на метод - содержит внутри себя блок команд, может принимать параметры.
//    Но он не может возвращать какое-либо значение. Используется для инициализации полей, выставления начальных значений
//    Конструктор по умолчанию - всегда есть в структурах, выставляет всем полям дефолтные значения.
// */
//Mike = new Person();  // Выделяем память под структуру, все поля имеют дефолтные значения

//Mike = new Person(); // Вызываем собственный конструктор по умолчанию
//Console.WriteLine(Mike.GetString());
//
// Mike = new Person("Mike", 18);              // Конструктор с параметрами
// Console.WriteLine(Mike.GetString());
//
// Mike = new Person("Mike");                  // Конструктор с дефолтными параметрами
// Console.WriteLine(Mike.GetString());
//
// Mike = new Person();                             // Конструктор с дефолтными параметрами   (или нет?)
// Console.WriteLine(Mike.GetString());

#endregion

// Mike = new Person("Mike", 18);
// Mike = new Person()
// {
//     Age = 18,
//     Name = "Mike"
// };

Console.ReadKey();


struct Person
{
    public string Name;    // Публичные поля
    public int Age;

    #region properties

    // public string Name
    // {
    //     get { return _name;}
    //     set { _name = value; }
    // }
    //
    // public int Age 
    // {
    //     get { return _age; }
    //     set { _age = value; } 
    // }

    #endregion
    
    #region private fields

        // private string name;
        // private int age;

    #endregion

    #region constructors
    /*
     Конструктор 
    public Имя_Класса(параметры)
    {
          // Тело конструктора
    }
    
    */
    // private Person()
    // {
    //     
    // }

    // public Person()
    // {
    //     Age = -1;
    //     Name = "DefaultName";
    // }
    //
    // public Person(string name, int age)
    // {
    //     Age = age;
    //     Name = name;
    // }
    
    // public Person(string name="Unnamed", int age=0)
    // {
    //     Age = age;
    //     Name = name;
    // }
    
    #endregion
    
    #region Methods
    
    public string GetString()
    {
        return $"Имя: {Name}  Возраст: {Age}";
    }  

    #endregion
}


#endregion