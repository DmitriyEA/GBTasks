using static System.Console;

WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(ReadLine());

if (a >= 100 && a <=999)
{
    WriteLine(a%10);
}
else
{
    WriteLine("Введено не трехзначное число.");
}