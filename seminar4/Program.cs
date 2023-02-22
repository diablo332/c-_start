//1:14:33
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