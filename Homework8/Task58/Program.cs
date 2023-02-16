// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

using static System.Console;
Clear();

Write("Введите размер матрицы 1 и диапазон значений через пробел: ");
int[] intParams1 = Array.ConvertAll(ReadLine()!.Split(new string[] { " ", ",", "#", ";", "." }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,] array1 = GetMatrixArray(intParams1[0], intParams1[1], intParams1[2], intParams1[3]);

Write("Введите размер матрицы 2 и диапазон значений через пробел: ");
int[] intParams2= Array.ConvertAll(ReadLine()!.Split(new string[] { " ", ",", "#", ";", "." }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,] array2 = GetMatrixArray(intParams2[0], intParams2[1], intParams2[2], intParams2[3]);


WriteLine("Матрица 1:");
PrintMatrixArray(array1);
WriteLine("Матрица 2:");
PrintMatrixArray(array2);

WriteLine();
WriteLine("Произведение двух матриц:");
PrintMatrixArray(MultArray(array1, array2));


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

int[,] MultArray(int[,] inArray1, int[,] inArray2)
{
  int[,] resultMatrix = new int[inArray1.GetLength(0),inArray2.GetLength(1)];
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < inArray1.GetLength(1); k++)
      {
        sum += inArray1[i,k] * inArray2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
return resultMatrix;
}