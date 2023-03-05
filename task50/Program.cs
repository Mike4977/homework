// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] =rnd.Next(min, max + 1);
        }
       
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //  Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
		else Console.Write($"{matrix[i, j], 4}");
        }
        // Console.Write("]");
        Console.WriteLine();
    }   
}

void PrintElement(int[,] matrix)
{
    int m = Promt("Введите номер строки массива");
    int n = Promt("Введите номер столбца массива");
    if (m > matrix.GetLength(0) || n > matrix.GetLength(1) || m < 0 || n < 0)
    {
    Console.WriteLine($"{m}, {n} -> такого элемента в массиве нет");
    }
    else Console.WriteLine($"{m}, {n} -> {matrix[m, n]}");
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);// можно добавить Promt для ввода данных массива
PrintMatrix(array2d);
PrintElement(array2d);
