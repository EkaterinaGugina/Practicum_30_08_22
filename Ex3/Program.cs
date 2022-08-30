//Ex57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] array = new int[m, n];
int max = array[0,0];
int min = array[0,0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]}\t");
        if (array[i, j] > max) max = array[i, j];
        if (array[i, j] < min) min = array[i, j];
    }
    Console.WriteLine();
}
for (int z = min; z <= max; z++)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (array[i, j] == z) count++;
        }
    }
    if (count != 0) Console.WriteLine($"'{z}' - {count} раз");
}

// второй способ
//int count = 0;
//int[,] result_arr = new int[array.GetLength(0) + 1, 2];
//result_arr[0,0] = array[0,0];
//for (int i = 0; i < array.GetLength(0); i++)
   // {
        //for (int j = 0; j < array.GetLength(1); j++)
        //{
        //    if (array[i,j] == result_arr[i,0]) 
        //    {
                
        //        count++;
        //    }
       // }
    //}
    