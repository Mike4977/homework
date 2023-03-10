// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка




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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
		else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine();
    }   
}

int[] SumElemRow(int[,] matrix)
{
	int[] array = new int[matrix.GetLength(0)];
	for(int i = 0; i < matrix.GetLength(0); i++)
	{
		int sum = 0;
		for(int j = 0; j < matrix.GetLength(1); j++)
		{
			 	sum = sum + matrix[i, j];
		}
		array[i] = sum;
	}
    return array;
}

int PrintNumberRows(int[] arr)
{
    int iMin = 0;
    int min = arr[iMin];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) 
        {
            min = arr[i];
            iMin = i;
        }
    }
    return iMin;
}

int row = Promt("Введите количество строк массива");
int col = Promt("Введите количество столбцов массива");
int minElement = Promt("Введите минимальное значение элемента массива");
int maxElement = Promt("Введите максимальное значение элемента массива");
Console.WriteLine();
int[,] array2d = CreateMatrixRndInt(row, col, minElement, maxElement);
int[] array = SumElemRow(array2d);
int numRows = PrintNumberRows(array);
PrintMatrix(array2d);
Console.WriteLine();
SumElemRow(array2d);
Console.WriteLine();
Console.Write($"Наименьшая сумма элементов в {numRows + 1} сроке.");

