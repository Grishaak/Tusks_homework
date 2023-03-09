// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool FindDigit(int[] arr, int dig)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == dig) return true;
    }
    return false;
}
int[] array = CreateArrayRndInt(7, -10, 11);
PrintArray(array);
Console.WriteLine("Введите искомое число:");
int digit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindDigit(array, digit)? "Число есть в массиве": "Числа нет в массиве");
