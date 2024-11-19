// Задание 3: Транспонирование двумерного массива
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).
// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6

// Метод создания двумерного массива
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

// Метод для вывода двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

// Метод замены строк и столбцов местами
int[,] TransposeMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i< matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

// Основная программа
int[,] array2d = CreateMatrixRndInt(3, 3, 0, 11);
PrintMatrix(array2d);

Console.WriteLine("Транспонирую массив:");

int[,] result = TransposeMatrix(array2d);
PrintMatrix(result);


