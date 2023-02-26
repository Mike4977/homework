// // Console.WriteLine("Введите число");
// // int number = Convert.ToInt32(Console.ReadLine());
// // int checkNumber = Check(number);

// // Console.WriteLine(checkNumber);

// // if (checkNumber == number) Console.Write("Да");
// // else Console.Write("Нет");

// // int Check (int num)
// // {
// //     int reversNum = 0;
// //     for (int i = num; i >= 1; i = i / 10) 
// //     {
// //         //int lastNum = num % 10;
// //         reversNum = reversNum * 10 + i % 10;//lastNum;
       
// //     }
// //     return reversNum; 
// // }



// // Пятизначное число

// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int checkNumber = Check(number);
// Console.WriteLine(checkNumber);
// if (checkNumber == number) Console.Write("Да");
// else Console.Write("Нет");

// int Check (int num)
// {
//     //int i = 10000;
//     //int res = 0;
//     while  (num >= 10)
//     {
//         //res = (num % 10);
//         Console.Write(num % 10);
//         num = num / 10;
//         //i = i / 10;
//     }
//     return num; 
// }



//массивы

int Promt(string message)     // Метод ввода чисел
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] FillArray(int length, int min, int max)     //Метод созания массива
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)    // Печать массива
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (j < arr.Length - 1) Console.Write($"{arr[j]}, ");
        else Console.Write(arr[j]);
    }
}

int length = Promt("Длина массива = ");
int min = Promt("Минимальное значение элемента массива = ");
int max = Promt("максимальное значение элемента массива = ");
int[] newArray = FillArray(length, min, max);
PrintArray(newArray);