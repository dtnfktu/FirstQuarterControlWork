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
}   // AutoInitStringArray

// Вывод массива строк
string ShowStringArray(string[] StringArray)
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
}   //ShowStringArray

// Создание нового массива, содержащего строки длина которых меньше либо равна 3 символа
string[] CreateNewStringArray(string[] MainStringArray, int StringLengthLimit = 3)
{
    string[] temp = new string[MainStringArray.Length];
    int MainStringArrayLength = MainStringArray.Length;
    int NewArrayLength = 0;

    for (int i = 0; i < MainStringArrayLength; i++)             // В данном цикле создаётся временный массив
    {                                                           // с максимально возможной длиной, 
        if (MainStringArray[i].Length <= StringLengthLimit)     // равной длине исходного массива
        {
            temp[NewArrayLength++] = MainStringArray[i];
        }
    }

    string[] result = new string[NewArrayLength];

    for (int i = 0; i < NewArrayLength; i++)                    // В данном цикле формируется массив
    {                                                           // актуальной длины
        result[i] = temp[i];
    }

    return result;
}   // CreateNewStringArray


Console.Clear();

string[] StringArray = AutoInitStringArray(ArrayLength: 10);

Console.WriteLine("Исходный массив строк : \n" + ShowStringArray(StringArray));

string[] NewStringArray = CreateNewStringArray(StringArray);

Console.WriteLine("\nПолученный массив строк : \n" + ShowStringArray(NewStringArray));