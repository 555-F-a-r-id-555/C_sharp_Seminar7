// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. 
// Матрица может быть прямоугольной


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

int sumElements(int m, int n)
{
    int sum = 0;
    int[,] newMatrix = randomMatrix(m, n);
    printMatrix(newMatrix, m, n);
    Console.Write("Сумма элементов главной диагонали: ");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                sum += newMatrix[i, j];
                if (j < m - 1) Console.Write($"{newMatrix[i, j]} + ");
                else if (j < m) Console.Write($"{newMatrix[i, j]}");
            }
        }


    }
    Console.WriteLine($" = {sum}");
    return sum;
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

sumElements(m, n);