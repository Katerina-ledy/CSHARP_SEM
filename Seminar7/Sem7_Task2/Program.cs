// Задание 2. Совместная работа
// Семинар 7. Рекурсия
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание: Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9


int SumDigits(int num) // 123, 12, 1, 0
{
    if (num == 0) return 0; // условие не выполняется и идем в 14 строку в SumDigits(num / 10) 
    return num % 10 + SumDigits(num / 10);  // 123, 12, 1
    // 1 % 10 => 1 + 12 % 10 => 2 + 123 % 10 => 3 = 1+2+3=6+0 (0 это от return пришло)
}

Console.WriteLine(SumDigits(123)); // 6


// int Factorial(int n)
// {
//     if (n == 1 || n == 0) return 1;
//     return n * Factorial(n-1);
// }

// Console.WriteLine(Factorial(5)); // 120

