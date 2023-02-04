// Не используя рекурсию, вывести первые N чисел Фибоначчи.

using static System.Console;
Clear();

int num = AskUserForNumber("Введите число для разложения в ряд Фибоначчи: ");

PrintArray(Fibonacci(num));


int[] Fibonacci(int inNum)
{
    int[] result = new int[inNum];
    result[0] = 0;
    result[1] = 1;

    for (int i = 2; i < inNum; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
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

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}