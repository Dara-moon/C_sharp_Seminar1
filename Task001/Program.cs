﻿/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет*/

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
if (first == Convert.ToInt32(Math.Pow(second, 2)))
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");