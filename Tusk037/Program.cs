//  Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] CompArray(int[] arr)//Функция вычисления произведений
{
    int size = arr.Length;
    int sizeNewArray = size / 2;
    if (size % 2 != 0) sizeNewArray = size / 2 + 1;
    int[] newArray = new int[sizeNewArray];
    for (int i = 0; i < sizeNewArray; i++)
    {
        newArray[i] = arr[i] * arr[size - i - 1];
        if (arr[i] == arr[size - i - 1]) newArray[i] = arr[i]; // Проверка на полследнее число
    }
    return newArray;
}

int[] array = CreateArrayRndInt(6, 1, 10);
PrintArray(array);
int[] newArrayInt = CompArray(array);
PrintArray(newArrayInt);




