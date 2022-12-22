using static System.Console;

Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 && number > 7)
{
    WriteLine("Это не день недели.");
}
else if (number > 0 && number < 6)
{
    WriteLine("Это рабочий день.");
}
else
{
    WriteLine("Это выходной день.");
}