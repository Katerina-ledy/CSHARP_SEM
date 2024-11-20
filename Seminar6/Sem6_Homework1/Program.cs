// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива.
// Пример
// a b c => “abcdef”
// d e f

string GetStringFromCharMatrix(char[,] matrix)
{
    string res = string.Empty;  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            res += matrix[i, j];
        }
        
    }
    return res;
}

char[,] matrix = { 
    {'a','b','c',},
    {'d','e','f'}
};
string result = GetStringFromCharMatrix(matrix);
Console.WriteLine(result);













