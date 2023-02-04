// напишите программу, которая принимает на входе три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

using static System.Console;
Clear();

int inA = AskUserForNumber("Введите длину стороны а: ");
int inB = AskUserForNumber("Введите длину стороны b: ");
int inC = AskUserForNumber("Введите длину стороны c: ");

WriteLine(IsTriangle(inA, inB, inC) ? "может быть треугольником" : "не может быть треугольником");

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

bool IsTriangle(int inA, int inB, int inC)
{
    return (inA + inB > inC && inB + inC > inA && inA + inC > inB);
}