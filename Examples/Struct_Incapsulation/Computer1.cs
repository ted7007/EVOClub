namespace Struct_Incapsulation;

public struct Computer1
{
    public string Title;

    public Computer1(string title)
    {
        Title = title;
    }

    /// <summary>
    /// Активация биоса
    /// </summary>
    public void ActivateBIOS()
    {
        Console.WriteLine($"{this.Title} | Activation BIOS...");
    }
    
    /// <summary>
    ///  Активация ОС
    /// </summary>
    public void ActivateOS()
    {
        Console.WriteLine($"{this.Title} | Activation OS...");
    }
    
    /// <summary>
    ///  Приветствие
    /// </summary>
    public void Greeting()
    {
        Console.WriteLine($"{this.Title} | Hello...");
    }

    /// <summary>
    ///  Деактивация биоса
    /// </summary>
    public void DeactivateBIOS()
    {
        Console.WriteLine($"{this.Title} | Deactivation BIOS...");
    }
    
    /// <summary>
    ///  Деактивация ОС
    /// </summary>
    public void DeactivateOS()
    {
        Console.WriteLine($"{this.Title} | Deactivation OS...");
    }

    /// <summary>
    ///  Прощание
    /// </summary>
    public void Parting()
    {
        Console.WriteLine($"{this.Title} | Bye...");
    }

    /// <summary>
    /// Метод демонстрирующий работу компьютера
    /// </summary>
    public void Calculation()
    {
        Console.WriteLine($"{this.Title} | Calculating...");

    }

}