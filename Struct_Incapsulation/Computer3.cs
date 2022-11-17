namespace Struct_Incapsulation;

public struct Computer3
{
    public string Title;

    private bool isOff;

    /// <summary>
    /// Лампочка питания. 1 - включен, 0 - выключен.
    /// </summary>
    public int Indicator
    {
        get
        {
            return isOff ? 0 : 1;
        }
    }

    public Computer3(string title)
    {
        Title = title;
        isOff = true;
    }
    
    /// <summary>
    /// Включение, если выключен; Выключение, если включен
    /// </summary>
    public void Power()
    {
        if (isOff)
        {
            PowerOn();
            isOff = false;
        }
        else
        {
            PowerOff();
            isOff = true;
        }
    }
    
    /// <summary>
    /// Включение
    /// </summary>
    private void PowerOn()
    {
        ActivateBIOS();
        ActivateOS();
        Greeting();
        Calculation();
    }

    /// <summary>
    /// Выключение
    /// </summary>
    private void PowerOff()
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