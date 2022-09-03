// Ex60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.//
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
int Sravn(int[,,] arr, int N, int x, int y, int z)
{
    for (int i = 0; i < x; i++)
    {  
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                if (arr[x, y, z] == N)
                {
                    Console.WriteLine("Такой элемент уже есть, меняем его на другой");
                    arr[x, y, z] = new Random().Next(10, 100);;
                    break;
                }
            }
        }
    }
    return arr[x, y, z];
}
void FillArrayCondition(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                //matr[i, j, k] = new Random().Next(10, 100);
                int count = 1;
                while (count <= (i + 1) * (j + 1) * (k + 1))
                {
                    matr[i, j, k] = Sravn(matr, matr[i, j, k], i, j, k);
                    count++;
                }       
                Console.Write($"{matr[i, j, k]}({i}{j}{k})\t");
            }
            Console.WriteLine();
        }
    }
}
int[,,] matrix = new int[2, 2, 2];
FillArrayCondition(matrix);
