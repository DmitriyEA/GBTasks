// Как массив строк перевести в массив чисел.

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ",", "#", ";", "."}, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
// int[] intParams = Array.ConvertAll(parameters, int.Parse);


int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);


PrintMatrixArray(array);



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
            Write($"{inArray[i, k], 5} ");     // "цифра 3" после запятой - количество символов, выделенных под выводимый элемент
        }
        WriteLine();
    }
}