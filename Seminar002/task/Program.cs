// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Input three digit number");
int number = Convert.ToInt32(Console.ReadLine());

int ShowSecondDigit(int number)
{
    
    int num1 = number / 10;
    int num2 = num1 % 10;
    Console.WriteLine(num2);
    return num2;
    
}



int res = ShowSecondDigit(number);

