// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
}

int[] array = new int[9];


PrintArray(array);

FillArray(array);

PrintArray(array);


// int[] array = new int[8];

//             void FillArray(int[] arr)
//             {
//                 Random rnd = new Random();
//                 for (int i = 0; i < arr.Length; i++)
//                 {
//                     arr[i] = rnd.Next(0, 2);

//                 }
//             }

//             void PrintArray(int[] arr)
//             {
//                 int count = arr.Length;
//                 for (int i = 0; i < count; i++)
//                 {
//                     Console.Write($"{arr[i] } ");
//                 }

//             }

//             FillArray(array);
//             PrintArray(array);