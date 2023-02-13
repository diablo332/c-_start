int x = 5;
int y = 3;

Console.WriteLine("Max = " + MaxOutputConsole(x, y));
Print("Hello");
int cti = ConsoleTakeInt();

Print(cti.ToString());

int ConsoleTakeInt()
{
    int number;
    Console.Write($"Введите число: ");
    bool flag = int.TryParse(Console.ReadLine()!, out number);
    if (flag){
        return number;
    }  else {
        Console.Write($"Введено не число\n");
        return ConsoleTakeInt();        
    } 
}

int MaxOutputConsole(int a, int b){
    int max = a;
    if (a > b) {
        max = a;
    } else {
        max = b;
    }
    return max;
}

void Print(string text){
    int length = text.Length;
    string border = "--";
    string textt = "|" + text + "|";
    for (int i = 0; i < length; i++)
        border += "-";
    Console.Write($"{border}\n{textt}\n{border}\n");    

}

/*void MaxOutputConsole(int a, int b){
    if (a > b) {
        Console.Write("Max = a");
    } else {
        Console.Write("Max = b");
    }
}*/