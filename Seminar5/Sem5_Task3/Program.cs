﻿// Задание 3. Совместная работа
// Семинар 5. Двумерные массивы
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max) // указываем тип возвращаемого значения, тип метода
{
    int[,] matrix = new int[rows, colums]; // матрица 3x4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  // for (int i = 0; i < rows; i++) // for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  //  for (int j = 0; j < colums; j++) //  for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = rnd.Next(min, max); // matrix[0,1,2, 0,1,2,3] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine(" |");
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]:F2}, ");
        }
        else
        Console.Write($"{array[i]:F2}");
    }
    Console.Write("]");
}

double[] GetAverageArrayRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i< matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = (double)sum / matrix.GetLength(1);
    }
    return array;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

double[] result =  GetAverageArrayRows(array2d);
PrintArray(result);


