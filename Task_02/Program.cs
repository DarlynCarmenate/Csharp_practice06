// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string message)
{
	Console.Write(message);
	string strValue = Console.ReadLine();
	int value = int.Parse (strValue);
	return value;
}

int b1 = Prompt("Введите значение b1: ");
int b2 = Prompt("Введите значение b2: ");
int k1 = Prompt("Введите значение k1: ");
int k2 = Prompt("Введите значение k2: ");

if(k1 == k2 && b1 == b2)
Console.WriteLine("Бесконечное пересечение");

else if(k1 == k2)
Console.WriteLine("Нет пересечений");

else
{
int x = (b2 - b1)/(k1 - k2);
int y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых {x}, {y}");
}