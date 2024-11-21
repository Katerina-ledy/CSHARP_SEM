// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: {1, 2, 3, 4, 5}
// ● Выход: 5, 4, 3, 2, 1
// ● Вход: {10, 20, 30, 40}
// ● Выход: 40, 30, 20, 10


// Метод для создания массива

int[] GetArrayRndInt(int sizeArray, int minValue, int maxValue)
{
    int[] rndArray = new int[sizeArray];
    Random rnd = new Random();

    for (int i = 0; i < rndArray.Length; i++)
    {
        rndArray[i] = rnd.Next(minValue, maxValue);
    }
    return rndArray;
}

// Метод для печати массива

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

// Метод для вывода элементов с конца массива (рекурсия)

void PrintNumOfArrayEndToBegin(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

    Console.Write(array[index]);

    if (index > 0)
    {
        Console.Write(", ");
    }
    PrintNumOfArrayEndToBegin(array, index - 1);

}

// Основная программа

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = GetArrayRndInt(size, 0, 9);
PrintArray(arr);
Console.Write(" => ");
PrintNumOfArrayEndToBegin(arr, size - 1);