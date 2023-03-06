// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int digits = Digits(number);
Console.WriteLine($"В числе {number} -> {digits} чисел");

int Digits(int numb)
{
    int countDigit = 0;
    while(numb != 0)
    {
        numb = numb / 10;
        countDigit++;
    }
    return countDigit;
}