// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// 
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[rows,columns];
// void mas(int rows, int columns)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < rows; i++)
// {
// Console.WriteLine();
// for (j = 0; j < columns; j++)
// {
// randomArray[i,j] = rand.NextDouble();
// Console.Write($"{randomArray[i,j]:F2} ");
// }
// }
// }
// mas(rows,columns);
// Второй способ(семинар8)
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// 
// double [,] array = new double [rows,columns];
// 
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//   array[i,j]= new Random().NextDouble()*10;
//   Console.Write("{0,6:F2}", array[i,j]);
//   }
//  }
//  Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Console.WriteLine("Введите строку: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int n = 5;
// int m = 7;
// int [,] arr = new int [n,m];
// Console.WriteLine("Исходный массив");
// 
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//  for (int j = 0; j < arr.GetLength(1); j++)
// {
// arr[i,j] = new Random().Next(0,10);
// Console.WriteLine(arr[i,j]+" ");
// }
// Console.WriteLine();
// }
//  if (rows < 0 | rows > arr.GetLength(0) - 1 | columns < 0 | columns > arr.GetLength(1) - 1)
// {
// Console.WriteLine("Элемент не существует  ");
// }
    // else
// {
    // Console.WriteLine("Значение элемента массива = {0}", arr[rows, columns]);
// }
// Console.ReadLine();
// 
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Console.WriteLine("Введите строку: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// 
// int [,] arr = new int [rows, columns];
// double sum = 0;
// 
// for (int i = 0; i < arr.GetLength(0); i++)
    // {
    //   for (int j = 0; j < arr.GetLength(1); j++)
    //   {
    //    arr[i, j] = new Random().Next(1, 10);
        // Console.Write(arr[i, j] + " ");
    // }
    // Console.WriteLine();
    //   }  
// for (int j = 0; j < arr.GetLength(1); j++)
// {
// sum = 0;
    // for (int i = 0; i < arr.GetLength(0); i++)
    // {
    //    sum += arr[i, j];
    // }
    // Console.WriteLine($"Среднее арифметическое столбца: { sum / arr.GetLength(0)} ");
// }
// Console.ReadLine();
    