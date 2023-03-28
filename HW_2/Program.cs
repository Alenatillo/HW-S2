// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этог
// 456 -> 5
// 782 -> 8
// 918 -> 1
// 
// Console.Write("Введите трехзначное число: ");
// string str = Console.ReadLine();
// char r = str[1];
// Console.WriteLine(r);
// 
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 
// Console.Write("Введите число: ");
// string anyNumber = Console.ReadLine();
// 
// if (anyNumber.Length > 2)
// {
    // Console.WriteLine("третья цифра ->" + anyNumber[2]);
// }
// else
// {
    // Console.WriteLine("-> третьей цифры нет");
// }
// 
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли 
// 6 -> да
// 7 -> да
// 1 -> нет
// 
// Console.Write("Введите цифру,  обозначающую день недели: ");
// int dayNumer = Convert.ToInt32(Console.ReadLine());
// 
// if (dayNumer == 6 || dayNumer == 7)
// {
    // Console.WriteLine("Выходной день!");
// }
// else if (dayNumer <1 || dayNumer >7)
// {
    // Console.WriteLine("В недели только 7 дней");
// }
// else Console.WriteLine("Рабочий день.");
