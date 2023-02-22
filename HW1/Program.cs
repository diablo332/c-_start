/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

bool isPalindrome(int a){
    string intToStr = a.ToString();
    int length = intToStr.Length;
        for (int i = 0; i < (length / 2); i++) {
            if (intToStr[i] != intToStr[length - i - 1]) {
                return false;
            }
        }
    return true;
}

int number;
Console.Write($"Введите пятизначное число: ");
bool isCorrect = int.TryParse(Console.ReadLine()!, out number);
if (isCorrect & number.ToString().Length == 5)
{
    if (isPalindrome(number)){
        Console.Write($"Число является палиндромом");
    } else {
        Console.Write($"Число не является палиндромом");
    }
} else {
    Console.Write($"Введено не корректное число");
}