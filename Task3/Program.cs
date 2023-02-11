string text;
int firstNumber;
Console.WriteLine("Введите число: ");
text = Console.ReadLine();
int.TryParse(text, out firstNumber);
if (firstNumber % 2 == 0) {
    Console.Write("Число чётное");
} else {
    Console.Write("Число нечётное");
}
