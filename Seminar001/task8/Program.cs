//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
int current;

Console.WriteLine("Input number: ");
N = Convert.ToInt32(Console.ReadLine());

current = 1;

while (current <= N)
{ if (current % 2 ==0)
    
    Console.Write(current + " ");
    current ++;
}
