// Напишите программу реализующую методы формирования массива,
// заполненного случайными числами и подсчета суммы элементов,
// стоящих на нечётных позициях.

using static System.Console;
Clear();

Write("Введите размер массива, min и max, через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();

WriteLine($"Сумма элементов на нечетных позициях, равна: {SumOddNumber(array)}");


int[] GetArray(int size, int min, int max)
{
    int[] ResultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        ResultArray[i] = rnd.Next(min, max + 1);
    }
    return ResultArray;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}

int SumOddNumber(int[] inArray)
{
    int result = 0;
    for (int i = 1; i < inArray.Length; i += 2)
    {
        result += inArray[i];
    }
    return result;
}