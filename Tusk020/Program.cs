// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// double res = 5.09987564;
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);

Console.WriteLine("Введите координаты точек А:");

int xCoordA = Convert.ToInt32(Console.ReadLine());
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точек B:");
int xCoordB = Convert.ToInt32(Console.ReadLine());
int yCoordB = Convert.ToInt32(Console.ReadLine());

double distance = FindAB(xCoordA,yCoordA,xCoordB,yCoordB);
Console.WriteLine($"Расстояние между точками равно:{Math.Round(distance)}");

double FindAB(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xA-xB, 2)+Math.Pow(yA-yB, 2));
} 