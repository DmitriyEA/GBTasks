// Задайте одномерный случайный массив из 12 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в промежутке от 10 до 99.


using static System.Console;

WriteLine("Введите размер массива, min и max, через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);

WriteLine();
WriteLine($"Количество элементов массива в диапазоне от 10 до 99, равно {CountNumbersInArray(array)}");




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

int CountNumbersInArray(int[] arr2)
{
    int count = 0;
    foreach (var numArr2 in arr2)
    {
        if (numArr2 >= 10 && numArr2 <= 99) count ++;
    }
    return count;
}