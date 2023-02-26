// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Метод заполнения массива случайными вещественными числами
double[] FillArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (rnd.NextDouble() * (max - min) + min);
        arr[i] = Math.Round(arr[i], 1, MidpointRounding.ToZero); // Округление элементов массива 
    }
    return arr;
}
// Метод вывода в консоль массива вещественных чисел 
void PrintArrayDouble(double[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
		else Console.Write(arr[i]);
    }
    Console.Write("]");
}
// Метод нахождения минимального элемента в массиве(вещественные числа)
double MinElement(double[] arr)
{
    double minElement = arr[0]; 
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement = arr[i];
    }
    return minElement;
}
// Метод нахождения максимального элемента в массиве(вещественные числа)
double MaxElement(double[] arr)
{
    double maxElement = arr[0]; 
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement = arr[i];
    }
    return maxElement;
}

double[] array = FillArrayRndDouble(9, 1, 100);
double maxElement = MaxElement(array);
double minElement = MinElement(array);
double differenceMaxMin = maxElement - minElement;
PrintArrayDouble(array);
Console.WriteLine($" -> {differenceMaxMin}");