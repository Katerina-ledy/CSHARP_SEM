// Задание 2. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите целое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    int secondDigit = num / 10 % 10;  // 487 / 10 = 48.7 = 48 % 10 = 4.8 = 8 
    int thirdDigit = num % 10;          // 487 % 10 = 48.7 = 7

    int result = secondDigit;         // result = 8
    int count = 1;

    while (count < thirdDigit)        // пока (1 < 7)
    {
        result = result * secondDigit;  // result *= secondDigit; 8 = 8 * 8
        count++;                       // count = count + 1 
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка ввода!");
}

