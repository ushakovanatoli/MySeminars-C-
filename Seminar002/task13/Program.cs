// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Input any number");
int number = Convert.ToInt32(Console.ReadLine());


int ShowThirdDigit(int number)

{
    if (number < 100) Console.WriteLine(" no third Digit ");
    while (number > 1000) number = number / 10;
    if (number > 100  )
    {
         number = number % 10;
        Console.WriteLine($"Third Digit of the number = {number} ");
    }
    return number;
}


int res = ShowThirdDigit(number);