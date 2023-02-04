// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; [6, 7, 19, 345, 3] -> нет
// 3; [6, 7, 19, 345, 3] -> да

// доделать


using static System.Console;

WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine("Введите размер массива, min и max, через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);

WriteLine();
WriteLine();

// consArray(array);






int[] GetArray(int size, int min, int max)
{
    int[] ResultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        ResultArray[i] = rnd.Next(min, max +1);
    }
    return ResultArray;
}

void PrintArray(int[] arr1)
{
    Write("[");
    for (int i = 0; i < arr1.Length - 1; i++)
    {
        Write($"{arr1[i]}, ");
    }
    Write($"{arr1[arr1.Length - 1]}]");
}

// bool consArray(int[] arr2)
// {
//     for (int i = 0; i < arr2.Length; i++)
//     {
//         if (arr2[i] == number) return true;
//         else return false;
//     }
//     return ...;
// }