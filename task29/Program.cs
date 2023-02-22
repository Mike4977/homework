// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

int[] RandomArray(int lenghtArr, int minNum, int maxNum)
{
	int[] newArr = new int[lenghtArr];
    Random rnd = new Random();
	for (int i = 0; i < lenghtArr; i++)
	{
		newArr[i] = rnd.Next(minNum, maxNum + 1);
	}
	return newArr;
}


void PrintArray(int[] array)
{
    // Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.Write(array[i]);
	}
    // Console.Write("]");
}	
		


int length = Promt("Введите длину массива");
int min = Promt("Введите минимальное значение элемента массива");
int max = Promt("Введите максимальное значение элемента массива");

int[] newArr = RandomArray(length, min, max);

PrintArray(newArr);
Console.Write(" -> [");
PrintArray(newArr);
Console.Write("]");