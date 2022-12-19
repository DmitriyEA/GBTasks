using static System.Console;

Write("Введите номер дня недели: ");
int day = Convert.ToInt32(ReadLine()!);

if (day > 0 && day < 8)
{
    if (day == 1)
    {
        Write("Это понедельник");
    }

    if (day == 2)
    {
        Write("Это вторник");
    }

    if (day == 3)
    {
        Write("Это среда");
    }

    if (day == 4)
    {
        Write("Это четверг");
    }

    if (day == 5)
    {
        Write("Это пятница");
    }

    if (day == 6)
    {
        Write("Это суббота");
    }

    if (day == 7)
    {
        Write("Это воскресенье");
    }
}
else
{
Write("Такого дня недели нет.");
}