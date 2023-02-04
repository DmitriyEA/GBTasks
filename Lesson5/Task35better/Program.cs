// Найдите произведение пар чисел в одномерном массиве.
// Парой чисел считается первый и последний, второй и предпоследний
// элементы массива и т.д.
// Результат вывести в новом массиве.


using static System.Console;

WriteLine("Введите размер массива, min и max, через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);

WriteLine();
WriteLine();
PrintArray(MultArray(array));




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

void PrintArray(int[] arr1)
{
    Write("[");
    for (int i = 0; i < arr1.Length - 1; i++)
    {
        Write($"{arr1[i]}, ");
    }
    Write($"{arr1[arr1.Length - 1]}]");
}

int[] MultArray(int[] arr2)
{
    int size = arr2.Length / 2;
    if (arr2.Length % 2 == 1) size++;

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = arr2[i] * arr2[arr2.Length - i - 1];
    }
    return result;
}