// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] randomMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
        }
    }
    return matrix;
}


void printMatrix(int[,] matrix, int m, int n)
{
    Console.WriteLine($"matrix[{m},{n}] = " + "\n{");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("}");
}


void columnsAverages(int m, int n)
{
    int sum = 0;
    int m1 = m;
    int n1 = n;
    int[,] matrix = randomMatrix(m1, n1);
    printMatrix(matrix, m1, n1);
    Console.Write("Среднее арифметическое каждого столбца: \n");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"Столбец №{j + 1} = {((double)sum / m1):f2}");
        sum = 0;
        if (j < matrix.GetLength(1) - 1) Console.WriteLine($";");

    }
    Console.WriteLine(".");
}

columnsAverages(3, 4);