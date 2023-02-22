// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int sumNumb = SumNumb(num);
Console.WriteLine($"Сумма цифр в числе {num} = {sumNumb}");

int SumNumb(int number)
{
	int sum = 0;
	while (number >= 1)
	{
		sum = sum + number % 10;
		number = number / 10;
	}
	return sum;
}