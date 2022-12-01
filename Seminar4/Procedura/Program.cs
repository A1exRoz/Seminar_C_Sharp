void maxNumbers(ref int a) // процедура
{
    a = a + 10;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
maxNumbers(ref n);
Console.WriteLine($"Результат: {n}");
