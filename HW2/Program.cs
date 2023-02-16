/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
int getThirthNumber(){
    int getNumber(){
        int number;
        Console.Write($"Введите число:\n");
        bool flag = int.TryParse(Console.ReadLine()!, out number);
        if (flag){
            return number;
        }  else {
            Console.Write($"Введите число:\n");
            return getNumber();        
        }
    }

    int number = getNumber();
    if (number >=100){
        while (number >= 1000){
            number = number / 10;
        }
        int thirthNumber = number % 10;
        Console.Write($"Третья цифра:" + thirthNumber.ToString());
        return thirthNumber;
    } else {
        Console.Write($"Третьей цифры нет. Введите трёхзначное число\n");    
        return getThirthNumber();
    }  
}
getThirthNumber(); 
