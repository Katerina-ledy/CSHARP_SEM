// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
// Пример
// “aBcD1ef!-” => “abcd1ef!-”

string UpperToLower(string str)
{
    string result = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if(char.IsUpper(str[i]))  // Проверка на заглавные буквы
        {
            result += char.ToLower(str[i]);
        }
        else
        {
            result += str[i];
        }
    }
    return result;
}

string str = "aBcD1ef!-";
string result = UpperToLower(str);
Console.WriteLine(result);










