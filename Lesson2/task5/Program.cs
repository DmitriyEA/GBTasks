using static System.Console;

WriteLine("Введите число а: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());

//if (a * a == b || b * b == a)

WriteLine(a * a == b? "b является квадратом числа a" 
        : b * b == a? "a является квадратом числа b" 
        : "не являются квадратами друг друга");