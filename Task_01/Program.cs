// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
	Console.Write(message);
	string strValue = Console.ReadLine();
	int value = int.Parse (strValue);
	return value;
}

int m = Prompt("Сколько чисел Вы хотите ввести? ");
int count = 0;

for(int i = 0; i < m; i++)
{
	int a = Prompt($"Введите число {i + 1}: ");
	if(a > 0) count++;
}

Console.WriteLine($"Вы ввели {count} положительных числа");