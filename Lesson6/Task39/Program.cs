// проверить шестизначный билет - счастливый он или нет?

using static System.Console;
Clear();


int ticket = AskUserForNumber("Введите номер билета: ");
WriteLine($"Результат: {IsLucky(ticket)}");

int IsLucky(int inNum)
{
    int a = inNum / 100000;
    int b = inNum
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