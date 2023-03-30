// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// 
// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 1;
// 
// if (b<1)
// {
// Console.Write("Число B должно быть натуральным\n");
// }
// else
// {
// while (b!=0)
// {
// c = c * a;
// b = b-1;
// }
// Console.Write($"Число A в натуральной степени B = {c}");
// }
// 
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// int sum = 0;
// 
// for (int i = 0; i < num.Length; i++)
// {
    // string str = Convert.ToString(num[i]);
//  int num1 = Convert.ToInt32(str);
//  sum+=num1;
// }
// Console.Write($"Сумма цифр в числе = {sum}");
// 
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// 
// int [] array = new int [8];
// 
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0,99); 
// }
// 
// Console.Write(String.Join(", ", array));


