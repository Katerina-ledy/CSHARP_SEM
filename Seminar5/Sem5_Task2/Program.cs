// Задание 2. Работа в сессионных залах
// Семинар 5. Двумерные массивы
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

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

int SumMainDiagonal(int[,] matrix)
{
    int sum = 0;

    // int minSize = matrix.GetLength(0);
    // if(matrix.GetLength(1) < minSize)
    // {
    //     minSize = matrix.GetLength(1);
    // }
    for (int d = 0; d < matrix.GetLength(0) && d < matrix.GetLength(1); d++)
    {
        sum = sum + matrix[d, d]; // sum += matrix[i,i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

int result = SumMainDiagonal(array2d);
Console.Write(result);


