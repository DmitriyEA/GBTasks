// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.


using static System.Console;
Clear();


WriteLine(GetSumm(403));


int GetSumm(int inNum)
{
    if (inNum == 0) return inNum;
    else
    {
        return GetSumm (inNum / 10) + inNum % 10;
    }

}