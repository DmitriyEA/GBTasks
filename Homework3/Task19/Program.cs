using static System.Console;

WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(ReadLine());

//WriteLine(number/1000%10);
//WriteLine(number/10%10);

WriteLine(Math.Abs(number) > 99999 | Math.Abs(number) < 10000 ? "Введено не пятизначное число." : number/10000 == number%10 && number/1000%10 == number/10%10 ? "Число является палиндромом." : "Число не является палиндромом.");