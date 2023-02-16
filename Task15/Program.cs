// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



bool Weekend (int numDay)
{
   return numDay == 6 || numDay == 7;
}

Console.WriteLine("Ввведите числло");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay > 7 || weekDay < 1) Console.WriteLine("Такого дня недели не  существует");

else if (Weekend(weekDay)) Console.WriteLine("да");
else Console.WriteLine("нет");

 