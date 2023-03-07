// Доп. задача: Вывести первые N строк треугольника Паскаля

// int ReadNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }



// void PrintFactorial(int n)
// {
//     int res = Factorial(n);
//     Console.WriteLine($"{n}! = {res}");
// }

// int n = ReadNumber("Введите число: ");

// PrintFactorial(n);

int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}

int[] PascalNumber(int n)
{
    int[] matrix = new int[n + 1];
    matrix[0] = 1;
    matrix[matrix.Length - 1] = 1;
    for (int i = 1; i < n; i++)
    {
        matrix[i] = Factorial(n) / (Factorial(i) * Factorial(n - i));
    }
    return matrix;
}

void Printmatrix(int n)
{
    int[] newMatrix = PascalNumber(n + 1);
    foreach (var item in newMatrix)
    {
        Console.Write($"{item} ");

    }
}

Printmatrix(4);