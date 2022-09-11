// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("input the number of the day of the week");
int number = Convert.ToInt32(Console.ReadLine());

void ShowThirdDigit(int number)
{
    if  (number == 1) Console.WriteLine("no");
    if (number == 2) Console.WriteLine("no");
    if (number == 3) Console.WriteLine("no");
    if (number == 4) Console.WriteLine("no");
    if (number == 5) Console.WriteLine("no");
    if (number == 6) Console.WriteLine("yes");
    if (number == 7) Console.WriteLine("yes");
    if (number > 7) Console.WriteLine(" incorrect data");
    
}


ShowThirdDigit( number);
