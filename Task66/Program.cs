// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


Console.WriteLine("Введите значение M: ");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine();
if(numberM <= 0 && numberN <= 0 ) Console.WriteLine("Нет решения!");
else if(numberM <= 0) numberM = 1;
else if(numberN <= 0) numberN = 1;
else 
{
    SumNaturalNumbers(numberM, numberN);
    Console.Write($"M = {numberM}, N = {numberN} -> {SumNaturalNumbers(numberM, numberN)} ");
    
}

int SumNaturalNumbers(int numM, int numN)
{
    if(numM > numN)
    {
        return numM + SumNaturalNumbers(numM - 1, numN);
    }
    else if(numM < numN)
    {
        return numN + SumNaturalNumbers(numM, numN - 1); 
    }
    else
    {
        return numM;
    }
}
