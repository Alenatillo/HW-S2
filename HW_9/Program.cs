﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// 
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// NaturalToLow(number, count);
// 
// 
// void NaturalToLow(int n, int count)
// {
    // if (count > n)
    // {
        // return;
    // }
    // else
    // {
        // NaturalToLow(n, count + 1);
        // Console.Write(count + " ");
    // }
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// 
// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum(int m, int n)
// {
// if (m==n)
// return n;
// else return m + sum(m + 1, n);
// }
// Console.Write($"Сумма натуральных элементов в промежутке от M до N = {sum(m,n)}");
// 
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// 
// int akkerman(int m, int n)
// {
//   if (m == 0) 
//   {
    // return n + 1;
//   }
//   else if (n == 0) 
//   {
    // return akkerman(m-1, 1);
//   }
// 
//   else
//   {
    // return akkerman(m-1, akkerman(m, n-1));
//   }
// }
// Console.Write($"Функция Аккермана = {akkerman(m, n)} ");
// 