/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int number;
Console.Write($"Введите число: ");
bool isCorrect = int.TryParse(Console.ReadLine()!, out number);
if (isCorrect)
{
    Console.Write($"{number} -> ");
    for (int i = 1; i <= number; i++)
    {
        if (i != number)
        Console.Write($"{Math.Pow(i, 3)}, ");
        else 
        Console.Write($"{Math.Pow(i, 3)}");
    }
} else {
    Console.Write($"Введено не корректное число");
}