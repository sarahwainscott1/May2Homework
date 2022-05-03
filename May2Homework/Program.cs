//Math Program
Random rand = new Random();
int Num1 = rand.Next(50);
int Num2 = rand.Next(20);

var sum = Num1 + Num2;
var subtract = Num1 - Num2; 
var multiply = Num1 * Num2;
var divide = decimal.Divide(Num1, Num2);

Console.WriteLine($"Numbers are {Num1} and {Num2}.");
Console.WriteLine($"Added is: {sum}");
Console.WriteLine($"Subtracted is: {subtract}");
Console.WriteLine($"Multiplied is: {multiply}");
Console.WriteLine($"Divided is: {divide}"); 

