using static System.Console;

Write("Введите число ");
int a = Convert.ToInt32(ReadLine());
int ostatok = a%2;

if (ostatok == 0)
{
    WriteLine($"Число {a} является четным.");
}
else
WriteLine($"Число {a} является нечетным.");