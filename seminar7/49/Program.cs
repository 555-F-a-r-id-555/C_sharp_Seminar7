// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ​
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] randomMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
        }
        Console.WriteLine();
    };
    return matrix;
}

int[,] newMatrix(int m, int n)
{
    int[,] newMatrix = randomMatrix(m, n);
    printMatrix(newMatrix, m, n);
    Console.WriteLine($"newMatrix[{m}x{n}] = " + "\n{");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0) newMatrix[i, j] *= newMatrix[i, j];
            Console.Write($"{newMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("}");
    return newMatrix;
}

void printMatrix(int[,] matrix, int m, int n)
{
    Console.WriteLine($"matrix[{m}x{n}] = " + "\n{");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("}");
}


int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");

newMatrix(m, n);