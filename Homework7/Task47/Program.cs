// Напишите программу реализующую метод, который возвращает
// массив размером m×n, заполненный случайными вещественными
// числами.

using static System.Console;
Clear();

Write("Введите размеры массива m и n через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(new string[] { " ", ",", "#", ";", "." }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

double[,] array = GetMatrixArray(intParams[0], intParams[1]);
PrintMatrixArray(array);




double[,] GetMatrixArray(int inRows, int inColumns)
{
    Random rnd = new Random();
    double[,] resultArray = new double[inRows, inColumns];
    for (int i = 0; i < inRows; i++)
    {
        for (int k = 0; k < inColumns; k++)
        {
            resultArray[i, k] = 20.0 * rnd.Next() / 2147483648 - 10.0;
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1); k++)
        {
            Write($"{inArray[i, k],5:f2} ");
        }
        WriteLine();
    }
}