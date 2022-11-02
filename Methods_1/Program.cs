Console.WriteLine("Введите размерность первой матрицы: ");
// число столбцов в певрой равно числу строк во второй
int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
Random rnd = new Random();  
for (int i = 0; i < A.GetLength(0); i++) // вносим рандомные числа
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = rnd.Next(10);
    }
}
Console.WriteLine("Введите размерность второй матрицы: ");
int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < B.GetLength(0); i++)        // вносим рандомные числа
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        B[i, j] = rnd.Next(10);
    }
}

Console.WriteLine("\nМатрица A:");
for (int i = 0; i < A.GetLength(0); i++)    // печатаем матрицу
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        Console.Write("{0} ", A[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine("\nМатрица B:");
for (int i = 0; i < B.GetLength(0); i++) // печатаем матрицу
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        Console.Write("{0} ", B[i, j]);
    }
    Console.WriteLine();
}



Console.WriteLine("\nМатрица C = A * B:");
int[,] C;


if (A.GetLength(1) != B.GetLength(0)) 
    throw new Exception("Матрицы нельзя перемножить");
int[,] r = new int[A.GetLength(0), B.GetLength(1)];
for (int i = 0; i < A.GetLength(0); i++)        // Умножаем
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        for (int k = 0; k < B.GetLength(0); k++)
        {
            r[i, j] += A[i, k] * B[k, j];
        }
    }
}
C = r;

for (int i = 0; i < C.GetLength(0); i++) // печатаем матрицу
{
    for (int j = 0; j < C.GetLength(1); j++)
    {
        Console.Write("{0} ", C[i, j]);
    }
    Console.WriteLine();
}
