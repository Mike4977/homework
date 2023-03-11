// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

int[,,] CreateMatrixRndInt(int rows, int columns, int depth)
{
    int m = 10;
    int[,,] matrix = new int[rows, columns, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = m;
                m ++;
            }
             
        }
       
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k], 4} ({i}, {j}, {k})");
		        else Console.Write($"{matrix[i, j, k], 4} ({i}, {j}, {k})");
            }
           
        }
        Console.WriteLine();
    }   
}


int row = Promt("Введите количество строк массива");
int col = Promt("Введите количество столбцов массива");
int dep = Promt("Введите глубину массива");

if(row * col * dep > 89) Console.WriteLine("Введены неверные параметры массива");
else PrintMatrix(CreateMatrixRndInt(row, col, dep));