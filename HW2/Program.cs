/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int a = TakeInt($"Введите число: ");

Console.Write($"{a} -> {getDigitsSum(a)}");

int getDigitsSum(int a){
    int result = 0;
    while (a != 0) {
        result += a % 10;
        a /= 10;     
    }
    return result;
}

int TakeInt(string str = $"Введите число: "){
    int number;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out number);
    return number;
}