// Задание 4. Совместная работа
// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

// Решение

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 || num <= -100)
{
    while (num > 999 || num < -999)
    {
        num = num / 10;               // Нашли третье число
    }
    int result = num % 10;
    Console.WriteLine("The third digit on the left " + result);
}
else
{
    Console.WriteLine("There is no third digit");
}



