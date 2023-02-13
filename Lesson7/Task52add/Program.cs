// Шахматная доска. Первая клетка - черная.
// Программа выводит ответ какого цвета клетка,
// по введенным координатам.

using static System.Console;
Clear();

Write("Введите координаты клетки: ");

string parameters = ReadLine()!;
int par1 = parameters[0];
int par2 = parameters[1];

WriteLine(par1);
WriteLine(par2);

if ((par1 + par2)%2 != 0)
{
    WriteLine("Черная клетка");
}
else
{
    WriteLine("Белая клетка");
}