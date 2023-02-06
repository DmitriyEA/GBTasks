// Напишите программу, которая принимаtn на вход два числа и
// возводит А в степень В.

using static System.Console;
Clear();


Write("Введите значения число и степень, через пробел: ");
string[] stringArgument = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(PowNumber(int.Parse(stringArgument[0]), (int.Parse(stringArgument[1]))));


int PowNumber(int inNum1, int inNum2)
{
    if (inNum2 == 1) return inNum1;
    else return PowNumber (inNum1, inNum2 - 1) * inNum1;
}