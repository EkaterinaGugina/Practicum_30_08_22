// Ex54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] FillArray(int[,] matr)       //заполнение и печать неупорядоченного массива из рандомных чисел
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
int[,] SortArray(int[,] matr)                      //сортировка по убыванию по строкам
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1; j++)
            {
                int max_position = j;
                for (int k = j + 1; k < matr.GetLength(1); k++)
                {
                    if(matr[i, k] > matr[i, max_position])   max_position = k;
                }
                    int current = matr[i, j];
                    matr[i, j] = matr[i, max_position];
                    matr[i, max_position] = current;
            }
        }
        return matr;
} 
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)  Console.Write($"{matr[i, j]}\t");
        Console.WriteLine();
    }
}
Console.WriteLine("Создаем матрицу. Количество строк m и столбцов n будут случайными и менее 10");
int m = Convert.ToInt32(new Random().Next(1, 10));
int n = Convert.ToInt32(new Random().Next(1, 10));
int[,] array = new int[m, n];
int[,] matrix = FillArray(array);
array = SortArray(matrix);
Console.WriteLine("Массив с упорядоченными по убыванию строками:");
PrintArray(array);
