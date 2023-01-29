// Напишите программу, реализующую метод, который формирует массив
// случайных целых чисел из 8 элементов и выводит их на экран.

using static System.Console;

Write("Введите размер массива: ");
int SizeArray = Convert.ToInt32(ReadLine());

int[] array = GetArray(SizeArray);
WriteLine();

PrintArray(array);



int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int k = 0; k < array.Length; k++)
    {
        Write($"{arr[k]}");
        if (k < array.Length - 1)
        {
            Write(", ");
        }
    }
    Write("]");
}