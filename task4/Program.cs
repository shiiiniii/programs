// Напишите программу, которая на вход принимает число и выдаёт его квадрат.
Console.Clear();
Console.Write("Введите квадрат какого числа Вы хотите получить: ");
int number = int.Parse(Console.ReadLine());
//Находим квадрат числа
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");