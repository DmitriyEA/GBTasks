using static System.Console;

int number = new Random().Next(100,1000);
WriteLine(number);

int ferst = number/100;
int last = number%10;

Write(ferst);
WriteLine(last);