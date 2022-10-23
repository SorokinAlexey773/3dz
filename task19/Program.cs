// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool Five (int number)
{
    int a = number / 10000;
    int b = number / 1000; b = number % 10;
    int d = number / 10; d = number % 10;
    int e = number % 10;
    return a == d && b == e;
}
Console.WriteLine("Введите 5-ти значное число : ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 100000 ) Console.WriteLine("Неккоректное число");
bool five = Five(num);
Console.WriteLine(five  ? $"{num} -> да": $"{num} -> нет");