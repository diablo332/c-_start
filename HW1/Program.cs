/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int a = TakeInt($"Введите число A: ");
int b = TakeInt($"Введите число B: ");

Console.Write($"{a} -> {getPow(a, b)}");

double getPow(int a, int b){
    double result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    return result;
}

int TakeInt(string str = $"Введите число: "){
    int number;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out number);
    return number;
}