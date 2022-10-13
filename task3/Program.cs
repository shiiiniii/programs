Console.Clear();
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int kostyl = number / 10;
int kray = number - kostyl * 10;
Console.WriteLine($"Последняя цифра числа {number} равна {kray}");