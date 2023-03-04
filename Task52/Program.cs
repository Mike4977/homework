// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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

double[] ArithmeticMean(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j]; 
        }
        arr[j] = sum / matrix.GetLength(0);
        arr[j] = Math.Round(arr[j], 1, MidpointRounding.ToZero);
        
    }
    return arr;
}
void PrintArray(double[] array)
{ 
    Console.Write/*Line*/("Среднее арифметическое каждого столбца:");
    for (int j = 0; j < array.Length; j++)
    {
        if (j < array.Length - 1) Console.Write($"{array[j], 4} ");
		else Console.Write($"{array[j], 4}");
    }
    Console.WriteLine();
}



int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);// можно добавить Promt для ввода данных массива
PrintMatrix(array2d);
Console.WriteLine();
double[] array = ArithmeticMean(array2d);
PrintArray(array);