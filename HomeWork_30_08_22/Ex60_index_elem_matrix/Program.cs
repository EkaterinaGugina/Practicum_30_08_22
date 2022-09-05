// Ex60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.//
void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++) Console.Write($"{matr[i, j, k]}({i}{j}{k})\t");
            Console.WriteLine();
        }
    }
}
int Sravn(int[,,] arr, int i, int j, int k)
{
    arr [i, j, k] = new Random().Next(10, 100);
    int result = 0;
    for (int x = 0; x <= i; x++)
    {
        for (int y = 0; y <= j; y++)
        {
            for (int z = 0; z <= k; z++)
            {
                if ((x == i) && (y == j) && (z == k))  break;
                else if (arr[x, y, z] == arr[i, j, k])
                {
                    result = 1;
                    break;
                }
            }
        }
    }
    if (result == 1) arr[i, j, k] = new Random().Next(10, 100);
    return arr[i, j, k];
}
int[,,] FillArrayCondition(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++) matr[i, j, k] = Sravn(matr, i, j, k);
        }
    }
    return matr;
}
int[,,] matrix = new int[3, 2, 3];
int [,,] resultArray = FillArrayCondition(matrix);
PrintArray(resultArray);
