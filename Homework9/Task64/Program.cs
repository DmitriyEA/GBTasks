// Напишите программу, которая реализует рекурсивный метод вывода
// всех натуральных числел в промежутке от N до 1.

using static System.Console;
Clear();

Write("Введите число N: ");
int N = Convert.ToInt32(ReadLine());

WriteLine($"Ряд чисел от {N} до 1: {GetNumbers(N)}");

string GetNumbers(int inNum)
{
    if (inNum > 0)
    {
        if (inNum == 1) return inNum.ToString();
        else return $"{inNum}, {GetNumbers(inNum - 1)}";
    }
    if (inNum == 1) return inNum.ToString();
    else return $"{inNum}, {GetNumbers(inNum + 1)}";
    
}

// на счет чисел я одуплился чуть позже, таки вспомнив, что натуральными
// являются числа - ЦЕЛЫЕ && ПОЛОЖИТЕЛЬНЫЕ...
// в общем, по условию задачи, проверка (if) на отрицательные не нужна, но
// мне нравится решение и я не хочу его менять )))
//
// ну а по факту, это должно выглядеть так:

// string GetNumbers(int inNum)
// {
//     if (inNum == 1) return inNum.ToString();
//     else return $"{inNum}, {GetNumbers(inNum - 1)}";
// }
