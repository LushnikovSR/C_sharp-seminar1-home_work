﻿// Задача № 8
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
int evenNumber = 2;
while (evenNumber <= number)
{
    int remainder = evenNumber % 2;
    if (remainder == 0)
    {
        Console.Write($"{evenNumber} ");
    }
    evenNumber++;
}