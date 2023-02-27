// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine($"Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine()); 

int result = RemainDigits(numberOne , numberTwo);
Console.WriteLine($"{result}");

Console.WriteLine(result == 0 ? "Кратно" : $"не кратно, остаток - {result}" );

int RemainDigits(int numb1, int numb2)
{
    return numb1 % numb2;
}