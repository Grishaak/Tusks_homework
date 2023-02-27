// ; 14. Напишите программу, которая принимает на
// ; вход число и проверяет, кратно ли оно
// ; одновременно 7 и 23.
// ; 14 -> нет
// ; 46 -> нет
// ; 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool mulit = Multi(number);
Console.WriteLine(mulit ? "Кратно" : "Не кратно");

bool Multi(int numb)
{
    return numb % 7 == 0 && numb % 23 == 0;
}


