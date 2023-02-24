Point point = new Point();
struct Point
{
    public double x;
    public double y;
    public double z;
    void TakeCoords(){

        string coords = Console.ReadLine()!;
        double[] numbers = coords.Split(' ').Where(x => double.TryParse(x, out _)).Select(double.Parse).ToArray(); 
        //List<int> numbers = new List<int>(Array.ConvertAll(coords.Split(' '), int.Parse));
        if (numbers.Length != 3){
            x = 0;
            y = 0;
            z = 0;
            return;
        }
            
        x = numbers[0];
        y = numbers[1];
        z = numbers[2];
    }
}

/* int a = TakeInt($"Введите число a: ");

Console.Write($"{a} -> {Digits(a)}");

int Digits(int a){
    //Факториал
    int result = 1;
    for (int i = 2; i <= a; i++)
    {
        result *= i;
    }
    return result;
}     */

/*int Digits(int a){
    //Возврат количества символов в числе
    int count = 0;
    if (a == 0)
        return 1;
    while (a != 0) {
        a /= 10;
        count++;
    }
    return count;
}*/

/*
int a = TakeInt($"Введите число a: ");

int Sum(int a){
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write($"{a} -> {Sum(a)}");
*/
int TakeInt(string str = $"Введите число: "){
    int number;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out number);
    return number;
}


/*int a = TakeInt($"Введите число a: ");
int b = TakeInt($"Введите число b: ");
int c = TakeInt(); */
//Console.Write(Text("Hello this is summ programm") );
/* Console.Write($"Введите число a: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число b: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"Введите число c: ");
int.TryParse(Console.ReadLine()!, out c);

Console.Write($"Max = {Max3(a, b, c)}" ); */

string Text (string text){
    string border = "--";
    for (int i = 0; i < text.Length; i++)
    {
        border += "-";
    }
    return $"{border}\n|{text}|\n{border}\n";
}

int Max3(int a, int b, int c){
    return Max(Max(a, b),c);    
}
 
int Max(int a, int b){
    int max = a;
    if (b > max){
        max = b;
    } else {
        max = a;
    }
    return max;    
} 
/* void Max(int a, int b){
    int max = a;
    if (b > max){
        max = b;
    } else {
        max = a;
    }
    Console.Write($"Max = {max}" );
} */