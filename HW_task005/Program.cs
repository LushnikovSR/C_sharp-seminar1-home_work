// Задача № 2
// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = double.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"max = {number1}");
}
else if (number2 > number1)
{
    Console.WriteLine($"max = {number2}");
}
else
{
    Console.WriteLine("Введенные числа равны.");
}
