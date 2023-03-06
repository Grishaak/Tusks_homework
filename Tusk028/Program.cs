// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

long factorial = Factorial(number);
Console.WriteLine($"Произведение всех числе от 1 до {number} -> {factorial}");

long Factorial(int numb)
{
    long result = 1;
    for (int i = 1; i <= numb; i++)
    {
        checked
        {
            result = result * i;
        }
    }
    return result;
}