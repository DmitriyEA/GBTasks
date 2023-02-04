// напишите программу, которая будет преобразовывать десятичное число
// в двоичное

using static System.Console;
Clear();

int num = AskUserForNumber("Введите число для перевода в двоичную систему: ");


WriteLine($"Результат: {ToBinary(num)}");

string ToBinary(int inNum)
{
    if (inNum == 0) return "0";
    string result = string.Empty;
    int temp;

    while (inNum > 0)
    {
        temp = inNum % 2;
        inNum /= 2;
        result = temp.ToString() + result;
    }
    return result;
}

int AskUserForNumber(string inString)
{
    int resultNum = 0;
    string userInput = "";

    while (!int.TryParse(userInput, out resultNum))
    {
        Console.Write(inString);
        userInput = Console.ReadLine()!;
    }
    return resultNum;
}