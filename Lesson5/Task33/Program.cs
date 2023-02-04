// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; [6, 7, 19, 345, 3] -> нет
// 3; [6, 7, 19, 345, 3] -> да

// решение не верное. TryParse не корректно работает в данном случае.
// нужно допилить.


using static System.Console;

WriteLine("Введите число: ");
int.TryParse(ReadLine(), out int number);

int[] array = {6, 7, 19, 345, 3};

WriteLine(consArray(array, number)? "да" : "нет");



bool consArray(int[] arr, int num)
{
    foreach (var i in arr)
    {
        if (num == i) return true;
    }
    return false;
}