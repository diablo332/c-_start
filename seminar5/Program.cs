int[] array2 = FillArray(3, 0, 10);
Console.Write($"{String.Join(", ", array2)}\n");
int[] array3 = new int[array2.Length / 2 + array2.Length % 2];
MultiplyPairs(array2, array3);
Console.Write($"{String.Join(", ", array3)}\n");

void MultiplyPairs(int[] arr, int[] pair){
    int size = arr.Length;
    int pairSize = pair.Length;

    for (int i = 0; i < size / 2; i++)
    {
        int rev = size - i - 1;
        pair[i] = arr[i] * arr[rev];    
    }
    if (size % 2 != 0){
        pair[pairSize - 1] = arr[pairSize - 1];
    }
}

/* void Change(int b)
{
    b = 1;
} */

/* int[] InverseElements(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;    
    }
    return arr;
} */

/* int pos = 0;
int neg = 0; */

/* foreach (int item in array2)
{
    pos += item > 0 ? item : 0; 
    neg += item < 0 ? item : 0; 
   if (item > 0){
        pos += item;
    } else {
        neg += item;
    }  
} */


int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr.SetValue(new Random().Next(min, max), i);
    }
    return arr;
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
/*int TakeInt(string str = $"Введите число: "){
    int number;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out number);
    return number;
}*/


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

/* string Text (string text){
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
}  */
/* void Max(int a, int b){
    int max = a;
    if (b > max){
        max = b;
    } else {
        max = a;
    }
    Console.Write($"Max = {max}" );
} */