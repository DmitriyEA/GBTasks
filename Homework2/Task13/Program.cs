using static System.Console;

Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//int count = 10;
//int result = number % count;

if (number > -99 && number < 99)
{
    Write("Третьей цифры нет.");
}
else if (Math.Abs(number / 100) > 9)
{
    while (Math.Abs(number / 100) > 9)
    {
        number = number / 10;
    }
Write($"Третьей цифрой числа данного числа является цифра {Math.Abs(number % 10)}.");
}
else
{
    Write($"Третьей цифрой числа данного числа является цифра {Math.Abs(number % 10)}.");
}