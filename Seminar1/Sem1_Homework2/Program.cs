// Задание 2
// Поиск среднего из трех чисел
// Описание: Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).
// Пример использования: На входе:
// ● a: 5  ● b: 3  ● c: 8
// На выходе:
// ● 5
// На входе:
// ● a: 1  ● b: 9  ● c: 7
// На выходе:
// ● 7

// Решение:

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && a <= c)
{
    int result = a;
    Console.WriteLine($"Среднее число = {result}!");
}
else if (b >= a && b <= c)
{
    int result = b;
    Console.WriteLine($"Среднее число = {result}!");
}
else
{
    int result = c;
    Console.WriteLine($"Среднее число = {result}!");
}
