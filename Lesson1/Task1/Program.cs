using static System.Console;

WriteLine("Является ли число а квадратом числа b?");
WriteLine("Введите число а: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);

if (b * b == a)
{
    WriteLine("ДА");
}
else
{
    WriteLine("НЕТ");
}