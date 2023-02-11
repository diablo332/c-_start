string text;
int firstNumber;
int count = 1;
Console.WriteLine("Введите число: ");
text = Console.ReadLine();
int.TryParse(text, out firstNumber);
while (count <= firstNumber) {
    if (count % 2 == 0) {
        Console.WriteLine("Чётное число: " + count);
    }
    count++;
}