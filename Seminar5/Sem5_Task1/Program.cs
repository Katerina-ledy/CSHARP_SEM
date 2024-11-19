// Задание 1. Совместная работа
// Семинар 5. Двумерные массивы
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3     
// 4 3 4 1   
// 2 9 5 4     

// =>
//     0  1  2  3 

// 0   4  3  4  3
// 1   4  3  4  1
// 2   2  9  25 4


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

void ElemEvenIndexesToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2) // i+=2 идти по четным числам
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)  // j+=2 идти по четным числам
        {
            // if(i % 2 == 0 && j % 2 == 0)
            // {
            matrix[i, j] *= matrix[i, j]; // *= умножить на саму себя, т.е. возвести в квадрат
            // }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

ElemEvenIndexesToSquare(array2d);
PrintMatrix(array2d);
