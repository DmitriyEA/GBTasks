using static System.Console;

Write("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int count = 2;

WriteLine($"Четные числа от 1 до {N}:");
while (count <= N)
{
    Write($"{count}, ");
    count = count + 2;
}