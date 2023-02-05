// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

using static System.Console;
Clear();

Write("Введите размер массива: ");
int SizeArray = Convert.ToInt32(ReadLine());

int[] array = GetArray(SizeArray);
WriteLine();
PrintArray(array);
WriteLine();
WriteLine($"Чисел, больше нуля: {compareNumbers(array)}");



int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
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

int compareNumbers(int[] inArray)
{
    int count = 0;
    foreach (var a in inArray)
    {
        if (a > 0) count++;
    }
    return count;
}