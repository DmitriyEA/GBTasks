// Напишите программу, которая принимет на вход число N
// и выдает сумму всех чисел от одного до N, на которые
// число N делится без остатка

using static System.Console;
Write("Введите число N: ");
int numberN = Convert.ToInt32(ReadLine());

int SummNumbers = Mult(numberN);
WriteLine($"Сумма чисел, на которые число {numberN}, делится без остатка, равно: {SummNumbers}");

int Mult(int num)
{
    int result = 0;
    int count = 1;
    while (count <= num)
    {
        if (num % count == 0)
        {
            //  WriteLine(num % count);
            //  Write(count);
            //  WriteLine(result);
            //  WriteLine();
             result = result + count;
        }
        count++;
    }
    return result;
}
