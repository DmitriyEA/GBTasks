// Не используя рекурсию, вывести первые N чисел Фибоначчи.

using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

Fibonacci(number);

void Fibonacci(int number)
{
    int temp, num1 = 0, num2 = 1;
    Write($"{num1} {num2} ");
    for (int i = 2; i < number; i++)
    {
        temp = num1 + num2;
        num1 = num2;
        num2 = temp;
        Write($"{num2} ");
    }
}