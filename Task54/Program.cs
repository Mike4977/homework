// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void FromMaxToMin(int[, ] matrix)
{
	for(int i = 0; i < matrix.GetLength(0); i++)
	{
		int temp = 0;
		for(int j = 0; j < matrix.GetLength(1); j++)
		{
			int max = matrix[i,j];
			for(int k = j + 1; k < matrix.GetLength(1); k++)
			{
				if(matrix[i, k] > matrix[i, j]) 
				{
					temp =  matrix[i, k];
					matrix[i, k] = matrix[i, j];
					matrix[i, j] = temp;
				}
			}
		}		
	}
}

int row = Promt("Введите количество строк массива");
int col = Promt("Введите количество столбцов массива");
int minElement = Promt("Введите минимальное значение элемента массива");
int maxElement = Promt("Введите максимальное значение элемента массива");
Console.WriteLine();
int[,] array2d = CreateMatrixRndInt(row, col, minElement, maxElement);
PrintMatrix(array2d);
Console.WriteLine();
FromMaxToMin(array2d);
PrintMatrix(array2d);