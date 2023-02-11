string text;
int firstNumber;
Console.WriteLine("Введите первое число: ");
text = Console.ReadLine();
int.TryParse(text, out firstNumber);
int secondNumber;
Console.WriteLine("Введите второе число: ");
text = Console.ReadLine();
int.TryParse(text, out secondNumber);
if (firstNumber > secondNumber) {
    Console.Write("Первое число (" + firstNumber + ") больше второго (" + secondNumber + ")");
} else if (firstNumber < secondNumber) {
    Console.Write("Второе число (" + secondNumber + ") больше первого (" + firstNumber + ")");
} else {
    Console.Write("Первое число (" + firstNumber + ") и второе число (" + secondNumber + ") равны");
}
