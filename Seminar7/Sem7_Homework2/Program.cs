// Задача 2: Функция Аккермана
// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 6


int GetFunAckerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return GetFunAckerman(n - 1, 1);
    }
    else
    {
        return GetFunAckerman(n - 1, GetFunAckerman(n, m - 1));
    }
}

int m = 2; 
int n = 3; 

int result = GetFunAckerman(n, m);
Console.WriteLine(result);


// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))










