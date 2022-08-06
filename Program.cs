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
