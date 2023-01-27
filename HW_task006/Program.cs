// Задача № 4
// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double number3 = double.Parse(Console.ReadLine());
double max = 0;

if (number1 >= number2)
{
    if (number1 >= number3)
    {
        max = number1;
    }
    else
    {
        max = number3;
    }
}
else
{
    if (number2 >= number3)
    {
        max = number2;
    }
    else
    {
        max = number3;
    }
}
Console.WriteLine($"{max}");
