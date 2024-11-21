// Задача 1: Вывод натуральных чисел в промежутке от M до N
// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8

int GetRandomNumInt(int minNum, int maxNum)
{
    Random rnd = new Random();
    int num = rnd.Next(minNum, maxNum);
    return num;
}

void PrintNaturalNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m},");
        PrintNaturalNumbers(m + 1, n);
    }
    else if (m == n)
    {
        Console.Write(n);
        return;
    }
    else
    {
        Console.Write($"{m},");
        PrintNaturalNumbers(m - 1, n);
    }
}

int M = GetRandomNumInt(0, 10);
int N = GetRandomNumInt(0, 10);

Console.Write($"M = {M}; N = {N}; => ");
PrintNaturalNumbers(M, N);


