using static System.Console;
using MyLib;
Clear();

int[] array1 = MyMethods.GetLineArray(10);
WriteLine($"{String.Join(" ",array1)}");

int[] array2 = MyMethods.GetLineArray(10, 20);
WriteLine($"{String.Join(" ",array2)}");

int[] array3 = MyMethods.GetLineArray(10, 5, 10);
WriteLine($"{String.Join(" ",array3)}");

// MyMethods.PrintArray;