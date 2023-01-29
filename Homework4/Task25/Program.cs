// Напишите программу, реализующую метод,который принимает
// на вход два числа (A и B) и возводит число A в натуральную
// степень B с использованием цикла.

using static System.Console;

Write("Введите число А: ");
int A = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int B = Convert.ToInt32(ReadLine());


WriteLine(A == 0? $"{A} ^ {B} = 0" : B > 0? $"{A} ^ {B} = {expo1(A, B)}" : B < 0? $"{A} ^ {B} = {expo2(A, B):f4}" : $"{A} ^ {B} = 1");





double expo1(double num1, double num2)
{
    double result = num1;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return result;
}

double expo2(double num1, double num2)
{
    for (int i = 1; i < Math.Abs(B); i++)
    {
        num1 *= A;
    }
    double result = 1 / num1;
    return result;
}