// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите, первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите, второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.WriteLine($"{numberA} больше {numberB}");
}
if (numberB > numberA)
{
    Console.WriteLine($"{numberB} больше {numberA}");
}
if (numberB == numberA)
{
    Console.WriteLine($"Числа {numberA} и {numberB} равны ");
}