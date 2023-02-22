// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



int[] Array(int q)
{
	int[] newArr = new int[q];
	for (int i = 0; i < q; i++)
	{
		newArr[i] = Convert.ToInt32(Console.ReadLine());
	}
	return newArr;
}


void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.Write(array[i]);
	}
}	
		

Console.WriteLine("Введите длину массива");
int quan = Convert.ToInt32(Console.ReadLine());

int[] newArr = Array(quan);

// Console.Write($" {PrintArray(newArr)} -> [ PrintArray(newArr)]");
PrintArray(newArr);