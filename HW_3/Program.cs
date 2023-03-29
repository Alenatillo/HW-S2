// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// 
// Console.WriteLine("Введите число");
// string num = Console.ReadLine();
// int len = num.Length;
// 
// if (len == 5)
// {
    // if (num[0] == num[4] && num[1] == num[3])
    // {
        // Console.WriteLine($"{num} - палиндром");
    // }
    // else
    // {
        // Console.WriteLine($"{num} - не палиндром");
    // }
// }
// else
// {
    // Console.WriteLine($"{num} - не является пятизначным");
// }
// 
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// 
// Console.WriteLine("Введите Х точки B");
// int XB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y точки B");
// int YB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z точки B");
// int ZB = Convert.ToInt32(Console.ReadLine());
// 
// Console.WriteLine("Введите Х точки A");
// int XA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y точки A");
// int YA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z точки A");
// int ZA = Convert.ToInt32(Console.ReadLine());

// double number = Math.Sqrt((Math.Pow ((XB-XA),2))+(Math.Pow ((YB-YA),2))+(Math.Pow ((ZB-ZA),2)));

// Console.Write(number);
// 
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

 Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i,3)+" ");
}