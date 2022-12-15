// Task53
// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void SwapFirstLastString (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int a = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = a;
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
inputMatrix(matrix);
SwapFirstLastString(matrix);


// или вот так:
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Enter matrix size n and m via space: ");
// string[] numbers = Console.ReadLine().Split(" ");
// int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
// int n = matrix.GetLength(0);
// int m = matrix.GetLength(1);
// int i = 0, j = 0;
// int p = 0, counter = -1;
// int size = n * m;
// int c = 1;

// while (counter < size)
// {
//     Console.WriteLine($"{i} {j} {p}");
//     if (j >= 0 && j < m && i < n)
//     {
//         matrix[i, j] = counter;
//     }
//     else if (p < m)
//     {
//         i = 0;
//         j = p;
//         p++;   // счетчик для сдвига вправо
//         matrix[i,j] = counter;
//     }
//     else if (p == m)
//     {
//         i = c;
//         c++;
//         j = m - 1;
//         matrix[i,j] = counter;
//     }
//     i++;
//     j--;
//     counter++;
// }
// PrintMatrix(matrix);