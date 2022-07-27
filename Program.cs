/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


int a, b;

Console.Write("Imput a = ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput b = ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b) Console.WriteLine("a - максимальное число, b - минимальное число ");
else Console.WriteLine("b - максимальное число, a - минимальное число ");
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


int a, b, c;

Console.Write("Imput a = ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput b = ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput c = ");
c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) Console.WriteLine("Максимальное число равно " + a);
else 
{
    if (b > a && b > c) Console.WriteLine("Максимальное число равно " + b);

else  
Console.WriteLine("Максимальное число равно " + c);
}
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


int number, remain;

Console.Write("Imput positive number = ");
number = Convert.ToInt32(Console.ReadLine());

remain = number%2;

if (remain != 0) Console.WriteLine("No. It's odd number!");
else Console.WriteLine("Yes. It's normal number!");
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int number, remain, current;

Console.Write("Imput positive number = ");
number = Convert.ToInt32(Console.ReadLine());

current = 1;

while(current < number)
{
remain = current%2;
    {
        if (remain > 0) current = current + 1; 
    
    }
Console.Write(current + " ");
current = current + 1;
}



