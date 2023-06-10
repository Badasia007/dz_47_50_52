//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();
Write("Введите колличество строк ");
int m = int.Parse(ReadLine());
Write("Введите колличество столбцов ");
int n = int.Parse(ReadLine());
Write("Введите искомое число;  ");
int number = int.Parse(ReadLine());
int[,] array = GetArray(m, n);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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

void FindingNumber(int[,] array2, int number)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (number == array2[i, j]){
            WriteLine($"Такой элемент есть в массиве --> {number}");
            return ;
            }
        }
    }
    WriteLine($"Такого элемента нет в массиве --> {number}");
}
FindingNumber(array, number);
