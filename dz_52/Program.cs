//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();
Write("Введите колличество строк ");
int rows = int.Parse(ReadLine());
Write("Введите колличество столбцов ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, 5);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

PrintArray(array);

void ArithmeticAverage(int[,] inArray)
{
    double[] sum = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum[i] += inArray[j, i];
        }
    }
    for(int i = 0; i < sum.Length; i++)
    {
        WriteLine($"Среднее арифметическое каждого столбца: {sum[i] / inArray.GetLength(0)}");
    }
}
ArithmeticAverage(array);
