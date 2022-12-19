using static System.Console;

WriteLine("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b ");
int b = Convert.ToInt32(ReadLine());
WriteLine("Введите число с ");
int c = Convert.ToInt32(ReadLine());

if (a > b && a > c)
{
    WriteLine($"Максимальным является число а = {a}");
}
if (b > a && b >c)
{
    WriteLine($"Максимальным является число b = {b}");
}
if (c > a && c > b)
{
    WriteLine($"Максимальным является число с = {c}");
}