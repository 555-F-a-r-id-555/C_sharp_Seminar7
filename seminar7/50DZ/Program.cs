// Задача 50: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] randomMatrix(int m, int n)
{
    Console.WriteLine($"matrix[{m}x{n}] = " + "\n{");
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("}");
    return matrix;
}

void getElement(int m, int n, int row, int colum)
{
    int[,] matrix = randomMatrix(m, n);
    if (row < m && colum < n) Console.WriteLine($"matrix[{row},{colum}] = {matrix[row, colum]}");
    else Console.WriteLine($"{row} {colum} -> такого числа в массиве нет");
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int row = ReadNumber("Введите номер строки, не индекс:") - 1;
int colum = ReadNumber("Введите номер столбца, не индекс:") - 1;

getElement(m, n, row, colum);