// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
Quart(number);

void Quart (int n)
{
    for (int i = 1; i <= n; i++)
    Console.WriteLine($"Кубы числа {i}-{Math.Cbrt(i)}");
}


