// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(new string[] { " ", ",", "#", ";", "." }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrixArray(array);

WriteLine();
FindRow(array);


int[,] GetMatrixArray(int inRows, int inColumns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[inRows, inColumns];
    for (int i = 0; i < inRows; i++)
    {
        for (int k = 0; k < inColumns; k++)
        {
            resultArray[i, k] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1); k++)
        {
            Write($"{inArray[i, k],5} ");
        }
        WriteLine();
    }
}

void FindRow(int[,] inArray)
{
    WriteLine("(КОНТРОЛЬ) Сумма элементов строки:");
    int n = 0;
    int[] arr = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            n += inArray[i, j];
        }
        WriteLine($"{i}: {n,5}");
        arr[i] = n;
        n = 0;
    }

    int min = arr[0];
    int result = 0;
    
    for (int k = 0; k < arr.Length - 1; k++)
    {
        if (arr[k] < min)
        {
            min = arr[k];
            result = k;
        }
    }
    WriteLine();
    WriteLine($"Строкой с наимньшей суммой элементов, является: {result} строка.");
}