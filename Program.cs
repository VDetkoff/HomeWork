﻿/*
//Домашняя работа 1 "Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее."

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());



if(num1 > num2)
{
    Console.WriteLine($"{num1} more than {num2} ");
}
if (num1 < num2)
{
    Console.WriteLine($"{num1} less than {num2} ");
}
*/

/*
//Домашняя работа 2 "Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел."

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;
{
    Console.WriteLine(max);
}
*/

/*
// Домашняя работа 3 "Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)."

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num%2 == 0)
{
    Console.WriteLine($"{num} an even number");
}
else 
{
    Console.WriteLine($"{num} odd number");
}
*/
/*
//Домашняя работа 4 "Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N."

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/