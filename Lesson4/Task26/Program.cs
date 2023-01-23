// Напишите программу, которая принимет на вход число N
// и выдает произведение всех чисел от одного до N

using static System.Console;
Write("Введите число N: ");
int numberN = Convert.ToInt32(ReadLine());

int MultNumbers = Mult(numberN);
WriteLine($"Произведение всех чисел от 1 до {numberN}, равно {MultNumbers}");

int Mult(int num)
{
    int result = 1;
    int count = 1;
    while (count <= num)
    {
        result = result * count;
        count++;
    }

    return result;
}
