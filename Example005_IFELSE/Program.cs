﻿Console.WriteLine("Введите имя пользователя");
string userName = Console.ReadLine();

if (userName.ToLower() == "Маша".ToLower()){
    Console.WriteLine("Ура, это же Маша!");
} else 
{
    Console.WriteLine("Привет, " + userName);
}