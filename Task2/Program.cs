string text;
int firstNumber;
Console.WriteLine("Введите первое число: ");
text = Console.ReadLine();
int.TryParse(text, out firstNumber);
int secondNumber;
Console.WriteLine("Введите второе число: ");
text = Console.ReadLine();
int.TryParse(text, out secondNumber);
int thirdNumber;
Console.WriteLine("Введите третье число: ");
text = Console.ReadLine();
int.TryParse(text, out thirdNumber);
int max = firstNumber;
string maxString = "";
if (firstNumber > max) {
    max = firstNumber;
    maxString = "Первое число (";
} 

if (secondNumber > max) {
    max = secondNumber;
    maxString = "Второе число (";
} 

if (thirdNumber > max) {
    max = thirdNumber;
    maxString = "Третье число (";
} 
Console.Write(maxString + max + ") максимальное ");