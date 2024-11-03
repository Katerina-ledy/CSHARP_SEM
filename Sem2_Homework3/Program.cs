// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// Пример
// 40 => 4
// 96 => 9
// 72 => 7
// Решение

Console.WriteLine("Введите положительное двузначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 || num <= 99)
{
    int firstDigit = num / 10;  // 26 / 10 = 2.6 = 2
    int secondDigit = num % 10;   // 26 % 10 = 2.6 = 6
    
    Console.WriteLine($"Первая цифра числа: {firstDigit}! вторая цифра числа: {secondDigit}!"); 
}
else if (firstDigit > secondDigit)
{
    int result1 = firstDigit;
    Console.WriteLine($"Наибольшая цифра числа: {result}!");
}
else if (firstDigit < secondDigit)
{
    int result2 = secondDigit;
    Console.WriteLine($"Наибольшая цифра числа: {result2}!");
}
else
{
    Console.WriteLine("Введено некорректное число!");
}

// вводим число и проверка на двузначность
// получить первую цифру затем вторую
// сравнить эти две цифры
// получаю результат в виде наибольшей цифры