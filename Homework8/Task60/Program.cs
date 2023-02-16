// Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

using static System.Console;
Clear();

Write("Введите размер массива X Y Z через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(new string[] { " ", ",", "#", ";", "." }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,,] array = new int[intParams[0], intParams[1], intParams[2]];

CreateArray(array);
PrintArray(array);




void CreateArray(int[,,] inArray)
{
  int[] temp = new int[inArray.GetLength(0) * inArray.GetLength(1) * inArray.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < inArray.GetLength(0); x++)
  {
    for (int y = 0; y < inArray.GetLength(1); y++)
    {
      for (int z = 0; z < inArray.GetLength(2); z++)
      {
        inArray[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray (int[,,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < inArray.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={inArray[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
