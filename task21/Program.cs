﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.
Console.WriteLine("Введите координаты A : ");
Console.WriteLine("X1  : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1  : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1  : ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты B : ");
Console.WriteLine("X2  : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2  : ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z2  : ");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double s = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1)*(z2 - z1));
    return s;
}