// Генерация массива строк, содержащих случайные символы
string[] AutoInitStringArray(int ArrayLength, int MinStringLength = 1, int MaxStringLength = 7)
{
    string[] NewArray = new string[ArrayLength];

    for (int i = 0; i < ArrayLength; i++)
    {
        int CurrentStringLength = new Random().Next(MinStringLength, MaxStringLength + 1);

        for (int j = 0; j < CurrentStringLength; j++)
        {
            NewArray[i] += (char) new Random().Next(32, 128);   // 32-127 - диапазон печатных символов
        }
    }

    return NewArray;
}

// Вывод массива строк
string ShowAStringArray(string[] StringArray)
{
    string result = "[";
    int Len = StringArray.Length;

    for (int i = 0; i < Len; i++)
    {
        result += "\"" + StringArray[i] + "\"";
        if (i < Len - 1) result += ", ";
    }

    result += "]";
    
    return result;
}




Console.Clear();

string[] StringArray = AutoInitStringArray(ArrayLength: 10);

Console.WriteLine("Исходный массив строк : \n" + ShowAStringArray(StringArray));