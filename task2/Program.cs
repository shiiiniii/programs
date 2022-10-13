//Умножить на -1 и двигаться от 1 числа ко 2 
Console.Clear();
Console.WriteLine("Вывод чисел от отрицательного до положительного");
Console.WriteLine("Введите отрицательное число ");
int number = int.Parse(Console.ReadLine());
int nbr = number * -1;
while (number <= nbr) 
{
    Console.Write($"{number}, ");
    number++;
}
 