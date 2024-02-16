// See https://aka.ms/new-console-template for more information

using CalcExample;
Clac calc = new Clac();
Console.WriteLine( "Add Call");
calc.Add(12, 45);

Console.WriteLine("Multi Call");
calc.Multi(12.2, 45.3);

Console.WriteLine("Sub Call");
calc.Sub(12.2, 45.3);
Console.WriteLine("div Call");
calc.div(12.2, 45.3);
Console.WriteLine("Avg Call");
calc.Avg(12.2, 45.3);

