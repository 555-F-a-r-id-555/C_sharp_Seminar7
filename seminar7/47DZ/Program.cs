// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void randomMatrix(int m, int n)
{
    Console.WriteLine($"matrix[{m},{n}] = " + "\n{");
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Random.Shared.NextDouble() * 10;
            Console.Write($"{matrix[i, j]:f2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("}");
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");

randomMatrix(m, n);