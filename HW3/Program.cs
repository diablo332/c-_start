/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
int getDayStatus(){
    int getDayNumber(){
        int number;
        Console.Write($"Введите день недели:\n");
        bool flag = int.TryParse(Console.ReadLine()!, out number);
        if (flag){
            return number;
        }  else {
            Console.Write($"Введите день недели:\n");
            return getDayNumber();        
        }
    }

    int numberOfDay = getDayNumber();
    if (numberOfDay >=1 & numberOfDay <= 7){
        if (numberOfDay <= 5){
            Console.Write($"Это рабочий день");
        } else {
            Console.Write($"Это выходной ☺");
        }
        
        return numberOfDay;
    } else {
        Console.Write($"Это не день недели. Введите день недели:\n");    
        return getDayStatus();
    }  
}
getDayStatus(); 
