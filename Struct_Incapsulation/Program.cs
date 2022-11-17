
using Struct_Incapsulation;

#region Computer1


Computer1 computer1 = new Computer1("DifficultPC");

computer1.ActivateBIOS();
computer1.ActivateOS();
computer1.Greeting();

computer1.Calculation();

computer1.DeactivateBIOS();
computer1.DeactivateOS();
computer1.Parting();

#endregion

#region Computer2
//
// Computer2 computer2 = new Computer2("Normal pc");
//
// computer2.PowerOn();
//
// computer2.PowerOff();

#endregion

#region Computer3

// Computer3 computer3 = new Computer3("Eazy pc");
//
// for (int i = 0; i < 5; i++)
// {
//     computer3.Power();
//
//     Console.WriteLine(computer3.Indicator);
// }

#endregion