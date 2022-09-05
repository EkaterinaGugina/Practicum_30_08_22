// Ex62. Напишите программу, которая заполнит спирально массив 4 на 4.
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
void PrintArray(int[,] matr)
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
int[,] FillArraySpiral(int[,] matr)
{
    int count = 0;
    int k = 1;
    while (count < matr.GetLength(0) / 2 + 1)
    {
        int i = count;
        for (int y = i; y < matr.GetLength(1) - count - 1; y++)     // проход направо
        {
            matr[i, y] = k;
            k++;
        }
        int j = matr.GetLength(1) - count - 1;
        for (int x = count; x < matr.GetLength(0) - count - 1; x++)  // проход вниз
        {
            matr[x, j] = k;
            k++;
        }
        i = matr.GetLength(0) - count - 1;
        for (int y = matr.GetLength(1) - count - 1; y > count; j--)     // проход налево
        {
            matr[i, y] = k;
            k++;
        }
        j = count;
        for (int x = matr.GetLength(0) - count - 1; x > count; x--)     // проход вверх
        {
            matr[x, j] = k;
            k++;
        }
        count++;
    }
    return matr;
}
int m = 4;
int n = 4;
int[,] matrix = new int[m, n];
int [,] resultSpiralArray = FillArraySpiral(matrix);
PrintArray(resultSpiralArray);
// spiral
// Console.Clear();

// var rand = new Random();
// int rows = rand.Next(4, 11);
// int cols = rows;
// int[,] numbers = new int[rows, cols];


// int value = 1;

// for (int shift = 0; shift < numbers.GetLength(0) - 2; shift++)
// {
//     for (int j = 0 + shift; j < numbers.GetLength(1) - shift; j++)
//     {
//         numbers[0 + shift, j] = value;
//         value++;
//     }
//     value--;
//     for (int i = 0 + shift; i < numbers.GetLength(0) - shift; i++)
//     {
//         numbers[i, numbers.GetLength(1) - 1 - shift] = value;
//         value++;
//     }
//     value--;
//     for (int j = numbers.GetLength(1) - 1 - shift; j >= 0 + shift; j--)
//     {
//         numbers[numbers.GetLength(0) - 1 - shift, j] = value;
//         value++;
//     }
//     value--;
//     for (int i = numbers.GetLength(0) - 1 - shift; i > 0 + shift; i--)
//     {
//         numbers[i, 0 + shift] = value;
//         value++;
//     }

// }

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if (numbers[i, j] < 10) Console.Write($"[{numbers[i, j]}]  ");
//         else Console.Write($"[{numbers[i, j]}] ");
//     }
//     Console.WriteLine();
// }