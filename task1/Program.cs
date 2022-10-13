Console.Clear();
Console.WriteLine("Является ли Ваше первое число квадратом второго?");
Console.WriteLine("Введите первое число, которое хотите проверить ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, которое хотите проверить ");
int numberB = int.Parse(Console.ReadLine());
int sqr = numberB * numberB;
if (sqr == numberA)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}