using static System.Console;

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

int MultNumber = GetMult(number);
WriteLine(number >= 0? $"Результат умножения всех чисел от {number} до 1, равен {MultNumber}": $"Результат умножения всех чисел от {number} до -1, равен {MultNumber}");


int GetMult(int num)
{
    int result = 1;
    
    if (num > 0)
    {
        while (num > 0)
        {
            result *= num;
            num--;
        }
    }
    else if (num < 0)
        while (num < 0)
        {
            result *= num;
            num++;
        }
    else result = 0;
    return result;    
}
