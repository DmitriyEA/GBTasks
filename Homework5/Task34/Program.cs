//  Напишите программу реализующую методы формирования массива,
// заполненного случайными положительными трёхзначными числами,
// и подсчета количества чётных чисел в массиве.


using static System.Console;

Write("Введите размер массива: ");
int SizeArray = Convert.ToInt32(ReadLine());

int[] array = GetArray(SizeArray);
WriteLine();
PrintArray(array);
WriteLine();
WriteLine($"В этом массиве {countEven(array)} четных числа(чисел).");



int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
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

int countEven(int[] inArray)
{
    int count = 0;
    foreach (var a in inArray)
    {
        if (a % 2 == 0) count++;
    }
    return count;
}