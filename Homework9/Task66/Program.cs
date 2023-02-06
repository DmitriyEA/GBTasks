// Напишите программу, которая реализует рекурсивный метод нахождения
// суммы натуральных элементов в промежутке от M до N.

using static System.Console;
Clear();


Write("Введите число М: ");
int M = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int N = Convert.ToInt32(ReadLine());

Write($"Сумма элементов от M до N, равна: {SumNumbers(M, N)}");


int SumNumbers(int inNum1, int inNum2)
{
    if(inNum1 < inNum2)
    {
    if (inNum1 == inNum2) return inNum1;
    else return SumNumbers(inNum1 + 1, inNum2) + inNum1;
    }
    else
    {
    if (inNum1 == inNum2) return inNum1;
    else return SumNumbers(inNum1 - 1, inNum2) + inNum1;
    }
}