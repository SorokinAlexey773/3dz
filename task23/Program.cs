// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);
void Cube(int n)
{
    if (n > 0)
    {
        int count = 0;
        while (n >= count)
        {
            Console.WriteLine($"{count,4}  {count * count*count,4}");
            count++;
        }
    }
    else Console.WriteLine("Некорректное число ");
}