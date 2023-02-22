// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int a = Promt("Введите первое число");
int b = Promt("Введите второе число");


int exponention = Exponention(a, b);
if (ValidNumB(b))
{
Console.WriteLine($"Число /{a} в степени {b} = {exponention}");
}
int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

int Exponention(int numA, int numB)
{
	int exp = 1;
	for (int i = 1; i <= numB; i++)
	{
		exp *= numA;// exp = exp * numA;
	}
	return exp;
}
bool ValidNumB (int numB)
{
	if (numB < 0)
	{
		 Console.WriteLine("Показатель степени не должен быть отрицательным");
		return false;
	}
	return true;	
}