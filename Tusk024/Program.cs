// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт 
// сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int summary = SummNumbers(number);
Console.WriteLine($"Сумма всех числе от 1 до {number} -> {summary}");

int SummNumbers(int numb)
{
    int result = 0;
    for (int i = 1; i <= numb; i++)
    {
        result = result + i;
    }
    return result;
}