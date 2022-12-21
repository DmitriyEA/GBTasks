using static System.Console;
Clear();

WriteLine("Введите число - ");

int number1 = Convert.ToInt32(ReadLine());

WriteLine(number1 % 7 == 0 && number1 % 23 == 0? "Кратно":"Некратно");
