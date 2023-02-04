// Напишите программу, реализующую методы формирования массива,
// заполненного случайными вещественными числами и вычисления
// разницы между максимальным и минимальным элементами массива.

using static System.Console;
Clear();

Write("Введите размер массива, min и max, через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();

WriteLine($"Разница значений max и min элементов, равна: {SubtractionResult(array)}");


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

int SubtractionResult(int[] inArray)
{
    int result = 0;
    if (inArray.Length < 2)
    {
        return result;
    }
    
    int min = inArray[0];
    int max = inArray[1];

    if (min > max)
    {
        min = inArray[1];
        max = inArray[0];
    }

    for (int i = 2; i < inArray.Length; i++)
    {
        if (inArray[i] < min)
        {
            min = inArray[i];
        }
        else if (inArray[i] > max)
        {
            max = inArray[i];
        }
    }
    return result = max - min;
}