// Напишите программу замены элементов массива: положительные
// на отрицательные и наоборот.

using static System.Console;

WriteLine("Введите размер массива, min и max, через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);

WriteLine();
WriteLine();

revArray(array);
PrintArray(array);






int[] GetArray(int size, int min, int max)
{
    int[] ResultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        ResultArray[i] = rnd.Next(min, max +1);
    }
    return ResultArray;
}

void PrintArray(int[] arr1)
{
    Write("[");
    for (int i = 0; i < arr1.Length - 1; i++)
    {
        Write($"{arr1[i]}, ");
    }
    Write($"{arr1[arr1.Length - 1]}]");
}

void revArray(int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        arr2[i] *= -1;
    }
}