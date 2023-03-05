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
    x = (bb - ba) / (ka - kb);
    y = ba + x * ka;

}
Console.WriteLine($"Координаты точки пересечения прямых -> ({x}, {y})");