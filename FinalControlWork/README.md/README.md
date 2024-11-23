# Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []


## Задаем начальный массив по умолчанию
string[] startArray = new string[] { "Hello", "2", "world", ":-)" };

## Массив для ввода с клавиатуры
 string[] startArray = InputArray();

## Подсчитываем длину нового массива
int newArrayLength = 0;
for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        newArrayLength++;
    }
}

## Создаем новый массив нужного размера
string[] strArray = new string[newArrayLength];
int index = 0;

## Заполняем новый массив строками
for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        strArray[index] = startArray[i];
        index++;
    }
}

## Метод для ввода массива строк
static string[] InputArray()
{
    Console.WriteLine("Введите количество строк в массиве:");
    int n = int.Parse(Console.ReadLine());
    string[] array = new string[n];      
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите строку [{i + 1}]:");
        array[i] = Console.ReadLine();
    }
    return array;
}

## Выводим результат
Console.WriteLine("Результат: [" + string.Join(", ", strArray) + "]");


