Console.WriteLine("Введите размерность первой матрицы: ");
// число столбцов в певрой равно числу строк во второй
int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];

Console.WriteLine("Введите размерность второй матрицы: ");
int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];

A = GetRandomArray(A.GetLength(0), A.GetLength(1));
B = GetRandomArray(A.GetLength(0), A.GetLength(1));

Console.WriteLine("\nМатрица A:");
Print(A);
Console.WriteLine("\nМатрица B:");
Print(B);
Console.WriteLine("\nМатрица C = A * B:");
int[,] C = Multiplication(A, B);
Print(C);

int[,] GetRandomArray(int length1, int length2)
{
    Random rnd = new Random();
    int[,] A = new int[length1, length2];

    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = rnd.Next(10);
        }
    }

    return A;
}

int[,] Multiplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}