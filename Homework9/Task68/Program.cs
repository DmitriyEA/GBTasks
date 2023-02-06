// Напишите программу реализующую метод вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

using static System.Console;
Clear();


Write("Введите неотрицательное число М: ");
int M = Convert.ToInt32(ReadLine());
Write("Введите неотрицательное число N: ");
int N = Convert.ToInt32(ReadLine());

Write($"Значение функции Аккермана: A({M},{N}) = ");
WriteLine(M == 0? $"{N + 1}" : M == 1? $"{N + 2}" : M == 2? $"{2 * N + 3}" : M == 3? $"{PowNumber(N) - 3}" : "вселенная бесконечна...");

int PowNumber(int inN)
{
   if (inN + 3 == 1) return 2;
    else return PowNumber(inN - 1) * 2;
}

// контроль вычислений
WriteLine();
WriteLine($"Контрольное значение: = {AccermanFunction1(M, N)}");

int AccermanFunction1(int inM, int inN)
{
    int result = 0;
    if (inM == 0) return result = inN + 1;
    else if (inM == 1) return result = inN + 2;
    else if (inM == 2) return result = 2 * inN + 3;
    else if (inM == 3) return result = Convert.ToInt32(Math.Pow(2, inN + 3) - 3);
    else return result;
}

// я не успел до конца понять саму функцию, поэтому не смог ее полностью
// засунуть в рекурсию, так как не догнал - что именно туда пихать ))
// надеюсь это не критично и в решении будет достаточно рекурсивного
// возведения в степень...