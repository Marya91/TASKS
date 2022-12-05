/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22   */

int a, b, d;
Console.Write($"Ввведите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Ввведите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"Ввведите третье число: ");
int.TryParse(Console.ReadLine()!, out d);

int max = a;
if (b > max)
    max = b;
if (d > max)
    max = d;

Console.Write($" max = {max}");