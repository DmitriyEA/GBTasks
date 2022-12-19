using static System.Console;

Write("Введите число: ");
int a = Convert.ToInt32(ReadLine());
int n = -(a);

if (a < 0)
{
    while (n > a)
    {
        Write($"{a} ");
        a = a + 1;
    }
}
if (a > 0)
{
    while (n <= a)
    {
        Write($"{n} ");
        n = n + 1;
    }
}
else WriteLine("null");