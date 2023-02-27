// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезак 10- 99 -> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
// if (secondDigit < firstDigit) Console.WriteLine($"НАибольшая числа числа равна -> {firstDigit}");
// else Console.WriteLine($"Наибольшая числа числа равна -> {secondDigit} ");

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// ИлИ вот так Console.WriteLine($"Наибольшая числа числа равна -> {result} ");

Console.WriteLine($"Наибольшая числа числа равна -> {(firstDigit > secondDigit ? firstDigit : secondDigit)} ");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая числа числа равна -> {maxDigit} ");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

