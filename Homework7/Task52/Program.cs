// Напишите программу реализующую методы, формирования
// двумерного массива и массива средних арифметических
// значений каждого столбца.

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(new string[] { " ", ",", "#", ";", "." }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrixArray(array);

WriteLine();
WriteLine("Среднее арифметическое каждого столбца:");
FindArray(array);



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

void FindArray(int[,] inArray)
{
    double temp = 0;
    double[] arr = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            temp += inArray[i, j];
        }
        arr[j] = temp / inArray.GetLength(0);
        temp = 0;
        Write($"{arr[j],5:f2} ");
    }
}