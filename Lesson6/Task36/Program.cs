using static System.Console;
Clear();
Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

// string stringArray = String.Join(",", array);
// WriteLine($"[{stringArray}]");

WriteLine($"[{String.Join(", ", array)}]");
ReversArray2(array);
WriteLine($"[{String.Join(", ", array)}]");
// dWriteLine($"[{String.Join(", ", ReversArray1(array))}]");


int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1, 10);
    }
    return resultArray;
}

int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }

    return result;
}

void ReversArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}