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
