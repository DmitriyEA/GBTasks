//Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

using static System.Console;

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

int Numbers = Result(number);
WriteLine($"Количество цифр в числе {number} = {Numbers}");



int Result(int num)
{
    int count = 0;
    if (num == 0)
    {
        count = 1;
    }
    else
    while (num != 0)
    {
        count++;
        num /= 10;
    }
    return count;
}