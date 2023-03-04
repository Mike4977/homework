// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double x = 0;
double y = 0;
int b1 = Promt("Введите b1");
int k1 = Promt("Введите k1");
int b2 = Promt("Введите b2");
int k2 = Promt("Введите k2");
IntersectionPoint(b1, k1, b2, k2);



int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}


void IntersectionPoint(double ba, double ka, double bb, double kb)
{
    // Console.WriteLine($"bb = {bb}");
    // Console.WriteLine($"ba = {ba}");
    // Console.WriteLine($"ka = {ka}");
    // Console.WriteLine($"kb = {kb}");
    // Console.WriteLine();
    x = (bb - ba) / (ka - kb);
    
    Console.WriteLine(x);

    y = ba + x * ka;
    
    Console.WriteLine(y);
    // x = Math.Round(x, 1, MidpodoubleRounding.ToZero);
    // y = Math.Round(y, 1, MidpodoubleRounding.ToZero);

    //Console.WriteLine(x);
    
}

// void PrdoubleArray(double[] arr)
// {
//      Console.Write("(");
//     for (double i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
// 		else Console.Write(arr[i]);
//     }
//     Console.Write(")");
// }

// Console.WriteLine($"{x}{Math.Pow(index, 3), 5}");
// Math.Round(x, 1, MidpodoubleRounding.ToZero); // Округление элементов массива 

//Console.WriteLine(doubleersectionPodouble(b1, k1, b2, k2));