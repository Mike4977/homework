// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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

int[,] MultiplicationMatrix(int[,] matrixC, int[,] matrixD)
{
   

	int[,] multiMatrix = new int[matrixC.GetLength(0), matrixD.GetLength(1)];
	for(int i = 0; i < matrixC.GetLength(0); i++)
	{
		for(int j = 0; j < matrixD.GetLength(1); j++)
		{
            multiMatrix[i, j] = 0;
            for (int k = 0; k < matrixC.GetLength(1); k++)
            {
                multiMatrix[i, j] += matrixC[i, k] * matrixD[k, j];
            }
			
		}
		
	}
    return multiMatrix;
}



int rowA = Promt("Введите количество строк массива A");
int colA = Promt("Введите количество столбцов массива A");
int rowB = Promt("Введите количество строк массива B");
int colB = Promt("Введите количество столбцов массива B");
int minElement = Promt("Введите минимальное значение элемента массива");
int maxElement = Promt("Введите максимальное значение элемента массива");
Console.WriteLine();
int[,] matrixA = CreateMatrixRndInt(rowA, colA, minElement, maxElement);
int[,] matrixB = CreateMatrixRndInt(rowB, colB, minElement, maxElement);
int[,] matrixMulti = MultiplicationMatrix(matrixA, matrixB);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();

if (colA != rowB)
        {
             Console.WriteLine ("Умножение не возможно! Неправильные размеры массивов");
        }
else PrintMatrix(matrixMulti);



