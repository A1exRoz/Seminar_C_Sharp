// Напишите программу, которая принимает на
// вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер четверти плоскости, в которой
// находится эта точка.

Console.Clear();

Console.Write("Ведите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");
