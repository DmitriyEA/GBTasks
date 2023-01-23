// создать массив из 8 чисел и заполнить его случайными числами 0 и 1

using static System.Console;

WriteLine("Введите размер массива: ");
int SizeArray = Convert.ToInt32(ReadLine());

int[] array = GetArray(SizeArray);
WriteLine();
PrintArray(array);



int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int k = 0; k < array.Length; k++)
    {
        WriteLine($"{arr[k]} ");
    }
}