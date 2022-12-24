using static System.Console;

Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5)
{
    WriteLine("Это рабочий день.");
}
else if (number ==6  | number == 7)
{
    WriteLine("Это выходной день.");
}
else
{
    WriteLine("Такого дня нет.");
}