namespace Struct_Incapsulation;

public struct Computer2
{
    public string Title;

    public Computer2(string title)
    {
        Title = title;
    }

    /// <summary>
    /// Включение
    /// </summary>
    public void PowerOn()
    {
        ActivateBIOS();
        ActivateOS();
        Greeting();
        Calculation();
    }

    /// <summary>
    /// Выключение
    /// </summary>
    public void PowerOff()
    {
        Parting();
        DeactivateBIOS();
        DeactivateOS();
    }
    
    /// <summary>
    /// Активация биоса
    /// </summary>
    private void ActivateBIOS()
    {
        Console.WriteLine($"{this.Title} | Activation BIOS...");
    }
    
    /// <summary>
    ///  Активация ОС
    /// </summary>
    private void ActivateOS()
    {
        Console.WriteLine($"{this.Title} | Activation OS...");
    }
    
    /// <summary>
    ///  Приветствие
    /// </summary>
    private void Greeting()
    {
        Console.WriteLine($"{this.Title} | Hello...");
    }

    /// <summary>
    ///  Деактивация биоса
    /// </summary>
    private void DeactivateBIOS()
    {
        Console.WriteLine($"{this.Title} | Deactivation BIOS...");
    }
    
    /// <summary>
    ///  Деактивация ОС
    /// </summary>
    private void DeactivateOS()
    {
        Console.WriteLine($"{this.Title} | Deactivation OS...");
    }

    /// <summary>
    ///  Прощание
    /// </summary>
    private void Parting()
    {
        Console.WriteLine($"{this.Title} | Bye...");
    }

    /// <summary>
    /// Метод демонстрирующий работу компьютера
    /// </summary>
    private void Calculation()
    {
        Console.WriteLine($"{this.Title} | Calculating...");

    }
}