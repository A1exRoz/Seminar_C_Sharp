// Задача 26: Напишите программу, которая
// принимает на вход число и выдаёт количество
// цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int size = 1;
while (n / 10 != 0)
{
    n /= 10;
    size++;
}
Console.WriteLine(size);