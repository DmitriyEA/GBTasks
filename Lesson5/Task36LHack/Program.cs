// как две переменные "положить" в один вывод, не используя циклы

using static System.Console;

Clear();

Write("Введите координаты А через пробел: ");
Point A = GetPointFromString(ReadLine()!);
Write("Введите координаты B через пробел: ");
Point B = GetPointFromString(ReadLine()!);

double delta = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2) + Math.Pow(A.Z - B.Z, 2));
WriteLine(delta);

Point GetPointFromString(string inStr)
{
    Point result = new Point();
    string[] par = inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    result.X = int.Parse(par[0]);
    result.Y = int.Parse(par[1]);
    result.Z = int.Parse(par[2]);
    return result;
}

struct Point
{
    public int X;
    public int Y;
    public int Z;
}