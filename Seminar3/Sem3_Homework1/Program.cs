// Задание 1: Поиск элемента в массиве
// Описание: Задайте массив целых чисел.
// Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве.
// Программа должна вывести:
// Присутствует/Не присутствует.

int[] array = {1, 3, 5, 10, 25, 55, 68, 99 };
int num = 55;

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;
    }
}
string result = isExistNum ? "Присутствует" : "Не Присутствует";
Console.WriteLine(result);
