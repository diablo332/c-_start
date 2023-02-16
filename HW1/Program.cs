/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
int getSecondNumber(){
    int getNumber(){
        int number;
        Console.Write($"Введите трёхзначное число:\n");
        bool flag = int.TryParse(Console.ReadLine()!, out number);
        if (flag){
            return number;
        }  else {
            Console.Write($"Введите трёхзначное число:\n");
            return getNumber();        
        }
    }

    int number = getNumber();
    if (number >=100 & number <=999){
        int secondNumber = number / 10 % 10;
        Console.Write($"Вторая цифра:" + secondNumber.ToString());
        return secondNumber;
    } else {
        Console.Write($"Вы ввели не трёхзначное число\n");    
        return getSecondNumber();
    }  
}
getSecondNumber(); 
