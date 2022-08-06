string[] StringsArray = new string[] {};
int n = InputNumbers("Введите количество элементов массива: ");
StringsArray = new string[n];
for (int i = 0; i < StringsArray.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    StringsArray[i] = Console.ReadLine()!;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int lengthLimit = 3;
int numbersItems = CheckArray(StringsArray, lengthLimit);
string[] StringsArray1 = new string[numbersItems];

int CheckArray(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}


FillNewArray(StringsArray, StringsArray1, lengthLimit);
Console.WriteLine($"{PrintArray(StringsArray1)}");

void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}


string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += "]";
    return result;
}
