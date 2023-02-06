// Задайте значения М и N. Напишите программу, которая выведет все
// натураьные числа в промежутке от М до N.

using static System.Console;
Clear();


WriteLine(GetNumbers1(10, 30));
WriteLine();
WriteLine(GetNumbers2(10, 15));

string GetNumbers1(int inNum1, int inNum2)
{
    
    if (inNum1 < inNum2)
    {
        if (inNum1 == inNum2) return inNum1.ToString();
        else return $"{GetNumbers1(inNum1, inNum2 - 1)}, {inNum2}";
    }
    else
    {
        if (inNum1 == inNum2) return inNum1.ToString();
        else return $"{GetNumbers1(inNum1 - 1, inNum2)}, {inNum1}";
    }

}

string GetNumbers2(int inNum1, int inNum2)
{
    if (inNum1 > inNum2)
    {
        int temp = inNum1;
        inNum1 = inNum2;
        inNum2 = temp;
    }
    return (inNum1 == inNum2) ? inNum2.ToString() : $"{GetNumbers2(inNum1, inNum2 - 1)}, {inNum2}";
}