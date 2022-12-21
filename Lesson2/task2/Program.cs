using static System.Console;

WriteLine("Введите число а: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());

WriteLine(a%b==0?"кратно":$"некратно, остаток {a%b}");