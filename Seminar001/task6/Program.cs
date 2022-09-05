// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).intnumber;
int number;

Console.WriteLine("Input number: ");
number = Convert.ToInt32( Console.ReadLine());

if (number % 2 == 0 )
{
    Console.WriteLine("number is even" );
}
else
{
Console.WriteLine("number is not even" );
}