// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23
// Пример
// a=50 => нет
// a=7 => нет
// a=322 => да

// Решение

Console.WriteLine("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{ 
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
