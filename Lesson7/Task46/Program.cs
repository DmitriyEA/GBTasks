using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
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