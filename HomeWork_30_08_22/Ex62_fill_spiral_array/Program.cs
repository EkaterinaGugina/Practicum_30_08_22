// Ex62. Напишите программу, которая заполнит спирально массив 4 на 4.
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
int[,] FillArray(int[,] matr)       //заполнение и печать массива
{
    int count = 0;
    while (count < 4)
    {
        int i = 0;
        for (int k = 0; k < 4; k++)
        {
            matr[i, k] = 10 * i + k + 1;
            Console.Write($"{matr[i, k]} ");
        }
        Console.WriteLine();
        int j = 3;
        for (int k = 1; k < 4; k++)
        {
            matr[k, j] = 10 * (- j -1) + j + 2;
            Console.Write($"{matr[k, j]} ");
        }
        Console.WriteLine();
    }

}

for (int i = 0; i < matr.GetLength(0); i++)
int[,] matrix = new int[4, 4];
FillArray(matrix);

