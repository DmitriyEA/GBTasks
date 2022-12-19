using static System.Console;

Write("Введите число а:");
int a = Convert.ToInt32(ReadLine());
Write("Введите число b:");
int b = Convert.ToInt32(ReadLine());

if (a > b)
{
    WriteLine("a больше b");
}
if (a < b)
{
    WriteLine("b больше a");
}
else            
{
    WriteLine("числа равны");
}