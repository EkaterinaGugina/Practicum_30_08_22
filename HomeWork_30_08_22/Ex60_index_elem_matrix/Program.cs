// Ex60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.//
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i}{j}{k})\t");
            }
            Console.WriteLine();
        }
    }
}
int Sravn(int[,,] arr, int marker)
{
    int result = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == marker)
                {
                    result = new Random().Next(10, 100);
                    break;
                }
            }
        }
    }
    return result;
}
int[,,] FillArrayCondition(int[,,] matr)
{
    int count = 1;
    int marker = 0;
    matr[0, 0, 0] = new Random().Next(10, 100);
    while (count <= matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {

                    matr[i, j, k] = new Random().Next(10, 100);
                    marker = matr[i, j, k];
                    int result = Sravn(matr, marker);
                    if (result == -1) Console.WriteLine("Одинаковых элементов нет");
                    else {matr[i, j, k] = result;}
                }
            }
        }
        count++;
    }
    return matr;
}
int[,,] matrix = new int[4, 2, 3];
int [,,] resultArray = FillArrayCondition(matrix);
PrintArray(resultArray);
