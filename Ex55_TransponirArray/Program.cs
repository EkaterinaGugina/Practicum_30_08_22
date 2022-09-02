//Ex55: Задайте двумерный массив. Напишите программу, которая заменяет 
//строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.


int[,] FillArray(int[,] matr)                   //заполнение и печать массива
{
    int[,] matrix = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-10, 10);    
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    return  matrix;
}
void PrintArray(int[,] matr)                  //печать массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void TransponirovArray(int[,] matr)                   //транспонирование массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            int currant = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = currant;
        }
    }
    PrintArray(matr);
}

Console.Write("Введите количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
if (m != n) 
{
    Console.WriteLine("Матрица не квадратная и транспонировать данную матрицу в неё саму невозможно");
}
int[,] array = new int[m, m];
int[,] matrix = FillArray(array);
Console.WriteLine();
TransponirovArray(matrix);


 