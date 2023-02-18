// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);

void Square (int num)
{
    for (int index = 1; index <= num; index++)
   { 
        Console.WriteLine($"{index, 5}{index * index * index, 5}");
   }
}
