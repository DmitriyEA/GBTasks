// Напишите программу, реализующую метод, который принимает на вход число
// и выдаёт сумму цифр в числе.

using static System.Console;

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());


WriteLine($"Сумма цифр в числе {number} = {SummNumbers(number)}");





int SummNumbers(int num)
{
    int result = 0;
        
    while (num % 10 != 0 | Math.Abs(num) > 1)
    {
        result += num % 10;
        num /=10;
    }
    
    return Math.Abs(result);
}