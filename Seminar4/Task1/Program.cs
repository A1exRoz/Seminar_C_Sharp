// Task 24. Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму
// чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Результат: {(n + 1) / 2 * n}");


