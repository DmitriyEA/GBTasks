using static System.Console;

WriteLine("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int count = 1;

if (N < 0)
{
    while (count >= N)
    {
    WriteLine($"N = {count}, N^3 = {Math.Pow(count, 3)}");
    count--;
    }
}
else
{
    while (count <= N)
    {
    WriteLine($"N = {count}, N^3 = {Math.Pow(count, 3)}");
    count++;
    }
}