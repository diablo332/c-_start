/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.Write("Введите число M: ");
int m = 0;
if (int.TryParse(Console.ReadLine(), out m)){
    Console.Write("Введите число N: ");
    int n = 0;
    if (int.TryParse(Console.ReadLine(), out n)){
        int akkerman = Akkerman(m, n);
        Console.Write($"Akkerman: {akkerman}");
    }
}
int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}