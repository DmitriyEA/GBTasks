using static System.Console;

WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine(number > 99 && number < 1000? number / 10 % 10 :"Это не трехзначное число.");