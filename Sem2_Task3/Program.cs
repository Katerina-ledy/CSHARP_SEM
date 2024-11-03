// Задание 3. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму (первое число делится ли на второе). Если первое число некратно второму,
// то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// Решение

Console.WriteLine("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = firstNumber % secondNumber;

if (remainder == 0)
{
    Console.WriteLine("Yes");
}
else
{
        Console.WriteLine("No, " + remainder);
}
