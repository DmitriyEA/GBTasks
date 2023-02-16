namespace MyLib;
using static System.Console;
public class MyMethods
{
    /// <summary>
    /// Метод 1
    /// </summary>
    public static int[] GetLineArray(int size)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next();
        }
        return result;
    }

    /// <summary>
    /// Метод 2
    /// </summary>
    public static int[] GetLineArray(int size, int maxValue)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(maxValue + 1);
        }
        return result;
    }

    /// <summary>
    /// Метод 3
    /// </summary>
    public static int[] GetLineArray(int size, int minValue, int maxValue)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(minValue, maxValue);
        }
        return result;
    }

    /// <summary>
    /// Вывод массива
    /// </summary>
    public static void PrintArray(int[] inArray)
    {

    }
}