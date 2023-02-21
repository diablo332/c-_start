// Вид 1

//int year = Method3();
//Console.WriteLine(year);

/* string Method4(int count, string c){
    int i = 0;
    string result = String.Empty;
    while (i <= count - 1){
        result += c; 
        i++;
    }
    return result;
} */

string Method4(int count, string c){
    string result = String.Empty;
    for (int i = 0; i < count; i++){
        result += c; 
    }
    return result;
}

string res = Method4(10, "asdf");
//Console.WriteLine(res);

/* for (int i = 2; i <= 10; i++){
    for (int j = 2; j <= 10; j++){
        Console.WriteLine($"{i} x {j} = {i * j}");
    }   
    Console.WriteLine(); 
} */

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что," +
    "ежели бы вас послали вместо нашего милого Винценгероде," +
    "вы бы взяли приступом согласие прусского короля." +
    "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue){
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
        {
            result += $"{newValue}";
        } else {
            result += $"{text[i]}";
        }
    }
    return result;
}

string newText = Replace(text, ' ', '|');
/* Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText); */

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }    
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSort2(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }    
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
SelectionSort2(arr);
PrintArray(arr);