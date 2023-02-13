// Напишите программу реализующую метод,принимающий позиции
// элемента в двумерном массиве, и возвращающий значение
// этого элемента или же указание, что такого элемента нет.

using static System.Console;
Clear();

WriteLine("Введите число а: ");
int a = Convert.ToInt32(ReadLine());

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(new string[] { " ", ",", "#", ";", "." }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrixArray(array);

WriteLine(checkInn(array, a)? $"В заданном масииве, есть число {a}" : $"В заданном масииве, числа {a} нет" );




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

bool checkInn(int[,] inArray, int num)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == num) return true;
        }
    }
    return false;
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