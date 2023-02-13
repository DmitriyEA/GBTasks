// Задать произвольный двумерный массив n на m. Вычмслить сумму
// элементов, находящихся в главной диагонали.

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ",", "#", ";", "."}, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrixArray(array);

int summ = 0;
for (int n = 0; n < (array.GetLength(0) < array.GetLength(1)? array.GetLength(0) : array.GetLength(1)); n++)
{
    summ += array[n, n];
   
}

WriteLine($"Сумма элементов главной диагонали, равна: {summ}");


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
            Write($"{inArray[i, k], 5} ");
        }
        WriteLine();
    }
}