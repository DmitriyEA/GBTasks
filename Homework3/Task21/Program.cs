using static System.Console;

WriteLine("Введите координаты точки А:");
Write("х: ");
double ax = Convert.ToDouble(ReadLine());
Write("у: ");
double ay = Convert.ToDouble(ReadLine());
Write("z: ");
double az = Convert.ToDouble(ReadLine());
WriteLine("Введите координаты точки B: ");
Write("х: ");
double bx = Convert.ToDouble(ReadLine());
Write("y: ");
double by = Convert.ToDouble(ReadLine());
Write("z: ");
double bz = Convert.ToDouble(ReadLine());

double x = Math.Abs(ax - bx);
double y = Math.Abs(ay - by);
double z = Math.Abs(az - bz);



WriteLine($"Длина отрезка АВ = {(Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2))):f2}");