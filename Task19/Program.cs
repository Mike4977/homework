﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int checkNumber = Check(number);
// Console.WriteLine(checkNumber);

if (checkNumber == number) Console.Write("Да");
else Console.Write("Нет");

int Check (int num)
{
    int reversNum = 0;
    while (num >= 1) 
    {
        reversNum = reversNum * 10 + num % 10;
        num = num / 10;
    }
    return reversNum; 
}




// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int checkNumber = Check(number);
// Console.WriteLine(checkNumber);
// if (checkNumber == number) Console.Write("Да");
// else Console.Write("Нет");

// int Check (int num)
// {
//     int i = 10000;
//     int res = 0;
//     while  (num >= 1)
//     {
//         res = res + ((num % 10) * i);
//         num = num / 10;
//         i = i / 10;
//     }
//     return res; 
// }