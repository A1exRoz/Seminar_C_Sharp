// Найти максимум среди 2-х чисел

int maxNumbers(int n, int m)  // функция
{
    if (n > m)
        return n;
    return m;
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {maxNumbers(n, m)}");