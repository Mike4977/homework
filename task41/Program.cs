// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputNumberInt(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int PositiveNumberQuantity(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
		else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int num = Promt ("Введите количество чисел");
Console.WriteLine("Введите числа");
int[] array = InputNumberInt(num);
PrintArray(array);
Console.WriteLine($" -> {PositiveNumberQuantity(array)}");