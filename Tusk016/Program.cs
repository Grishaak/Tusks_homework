// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine($"Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

bool result = SquadNumbers(numberOne, numberTwo); 
Console.WriteLine(result ? $"Числа {numberOne} и {numberTwo} являются квадратами" : $"Числа {numberOne} и {numberTwo} не являются квадратами");

bool SquadNumbers(int number1, int number2)
{
    return (number1 == number2*number2) || (number2 == number1*number1);
}