// Необходимо, используя рекурсивный метод, вывести
// все натуральные числа от 1 до N.

using static System.Console;
Clear();

// метод 1 (собирает строку)

string result = GetNumbers(10);
WriteLine(result);

WriteLine(GetNumbers1(10));
PrintNumbers(15);

string GetNumbers(int inNum)
{
    if (inNum == 1) return inNum.ToString();
    else return $"{GetNumbers(inNum - 1)}, {inNum}";
}


string GetNumbers1(int inNum)
{

    return (inNum == 1) ? inNum.ToString() : $"{GetNumbers1(inNum - 1)}, {inNum}";

    // if (inNum == 1) return inNum.ToString();
    // else return $"{GetNumbers1(inNum - 1)}, {inNum}";
}


// метод 2 (вызывать не готовую строку, а напрямую метод,
// который будет выводить данные

void PrintNumbers(int inNum)
{
    if (inNum == 1) Write(inNum);
    else
    {
        PrintNumbers(inNum - 1);
        Write($", {inNum}");
    }
}
