// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

Write("Введите число b1: ");
int b1 = int.Parse(ReadLine()!);
Write("Введите число k1: ");
int k1 = int.Parse(ReadLine()!);
Write("Введите число b2: ");
int b2 = int.Parse(ReadLine()!);
Write("Введите число k2: ");
int k2 = int.Parse(ReadLine()!);

FindLineCrossing(b1, k1, b2, k2);

void FindLineCrossing(double num11, double num12, double num21, double num22)
{
    double x = (num21 - num11) / (num12 - num22);
    double y = num12 * x + num11;
    WriteLine($"x = {x}, y = {y}");
}