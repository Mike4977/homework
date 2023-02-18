// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}
int xA = Promt ("Введите координату X точки А");
int yA = Promt ("Введите координату Y точки А");
int zA = Promt ("Введите координату Z точки А");
int xB = Promt ("Введите координату Х точки B");
int yB = Promt ("Введите координату Y точки B");
int zB = Promt ("Введите координату Z точки B");


double distance = Distance (xA, yA, zA, xB, yB, zB);

double d = distance;
double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(dRound);

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int resX = x2 - x1;
    int resY = y2 - y1;
    int resZ = z2 - z1;
    double result = Math.Sqrt(resX * resX + resY * resY + resZ * resZ);
    return result;
}

    // Math.Sqrt(5); 
    // Math.Pow(2, 10)
    // double d = 5.09998774;
    // double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
    // Console.WriteLine(dRound);
    