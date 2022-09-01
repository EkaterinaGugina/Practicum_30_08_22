// Ex58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] FillArray(int numstr, int numcol)            // заполнение массива
{
    int[,] matr = new int[numstr, numcol];
    for (int i = 0; i < numstr; i++)
    {
        for (int j = 0; j < numcol; j++)   matr[i,j] = new Random().Next(1,10); 
    }
    return matr;
}
void PrintArray(int[,] matr)                        // печать массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    { 
        for (int j = 0; j < matr.GetLength(1); j++)  Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
}
void MultiplMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matrixAB = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)   matrixAB[i, j] += matr1[i, k] * matr2[k, j];
            Console.Write($"{matrixAB[i, j]} ");
        }
        Console.WriteLine();
    }
} 
Console.Write("Введите размер первой матрицы: укажите количество строк m1 = ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("  и столбцов n1 = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите размер второй матрицы: ПОМНИТЕ, УМНОЖEНИЕ ВОЗМОЖНО, если число столбцов {n1} первой матрицы равно числу строк второй матрицы.");
Console.Write("Укажите количество строк m2 = ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("  и столбцов n2 = ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (m2 != n1) 
{
    Console.WriteLine("Матрицы НЕЛЬЗЯ умножить!");
    Console.WriteLine($"Число столбцов {n1} первой матрицы неравно числу строк {m2} второй матрицы!");
    Console.WriteLine($"Мы возьмем его правильно: m2 = n1 = {n1}");
    m2 = n1;
}
int[,] matrixA = FillArray(m1, n1);
int[,] matrixB = FillArray(m2, n2);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
MultiplMatrix(matrixA, matrixB);
