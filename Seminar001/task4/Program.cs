//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int numberA;
int numberB;
int numberC;

Console.WriteLine("Input numberA: ");
numberA = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Input numberB: ");
numberB = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Input numberC: ");
numberC = Convert.ToInt32( Console.ReadLine());

int max = numberA;

if (numberA > max ) max = numberA;
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;

Console.WriteLine($"  max = {max} ");