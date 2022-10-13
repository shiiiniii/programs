//Напишите программу, которая будет выдавать название дня недели по заданному номеру
Console.Clear();
string[]days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите номер дня недели: ");
int NumberOfDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(days[NumberOfDay - 1]);