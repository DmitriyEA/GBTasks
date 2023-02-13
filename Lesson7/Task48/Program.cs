// Задайте двумерный массив m на n. Каждый элемент массива,
// равен m + n.

using static System.Console;
Clear();

Write("Введите размер матрицы m и n: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);



int[,] GetMatrixArray(int inRows, int inColumns)
{
    int[,] resultArray = new int[inRows, inColumns];
    for (int m = 0; m < inRows; m++)
    {
        for (int n = 0; n < inColumns; n++)
        {
            resultArray[m, n] = m + n;
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
            Write($"{inArray[i, k], 5} ");     // "цифра 3" после запятой - количество символов, выделенных под выводимый элемент
        }
        WriteLine();
    }
}