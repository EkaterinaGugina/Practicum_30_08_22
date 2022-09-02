//Ex53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

int[,] FillArray(int[,] matr)                  //заполнение и печать массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-10, 11);    
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
    return matr;
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
Console.Write("Введите размер матрицы. Укажите количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("  и столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[,] chang_array = FillArray(matrix);
for (int j = 0; j < chang_array.GetLength(1); j++)
    {
        int currant = chang_array[0, j]; 
        chang_array[0, j] = chang_array[chang_array.GetLength(0) - 1, j]; 
        chang_array[chang_array.GetLength(0) - 1, j] = currant;
    }
Console.WriteLine();
PrintArray(chang_array);

 
