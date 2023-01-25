//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите, первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите, второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите, третье число: ");
int numberC = int.Parse(Console.ReadLine()!);

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"{numberA} максимальное число");
}

if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine($"{numberB} максимальное число");
}

if (numberC > numberB && numberC > numberA)
{
    Console.WriteLine($"{numberC} максимальное число");
}