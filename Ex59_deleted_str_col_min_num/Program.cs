//Ex59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, на выходе получим 
//следующий массив:
//9 4 2
//2 2 6
//3 4 7

int[,] FillArray(int[,] matr)                   //заполнение и печать массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);    
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
    return  matr;
}
int[] SeachMinElemArray(int[,] array)   // поиск индекса мин эл-та матрицы
{
    int[] ind_min = {0,0};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] < array[ind_min[0], ind_min[1]]) 
                {   
                    ind_min[0] = i;   //номер строки минимального элемента
                    ind_min[1] = j;   //номер столбца минимального элемента
                }
            }
    }
    //Console.WriteLine($"Индекс минимального элемента {array[ind_min[0],ind_min[1]]}: {ind_min[0]}, {ind_min[1]}");
    return ind_min;
}
void PrintArray(int[,] matr, int[] position_min_element)                   //заполнение и печать массива
{
    for (int i = 0;  i < matr.GetLength(0); i++)
    {
        for (int j = 0;  j < matr.GetLength(1); j++)
        {
            if (i != position_min_element[0] && j != position_min_element[1])  Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Создаем матрицу. Количество строк m и столбцов n будут случайными, но не более 10");
int m = Convert.ToInt32(new Random().Next(1, 10));
int n = Convert.ToInt32(new Random().Next(1, 10));
int[,] array = new int[m, n];
int[,] matrix = FillArray(array);
Console.WriteLine();
int[] ind_min_elem = SeachMinElemArray(matrix); 
Console.WriteLine($"Индекс минимального элемента: {SeachMinElemArray(matrix)[0] + 1}, {SeachMinElemArray(matrix)[1] + 1}");
Console.WriteLine($"Матрица с удаленными {SeachMinElemArray(matrix)[0] + 1}-й строкой и   {SeachMinElemArray(matrix)[1] + 1}-м столбцом:");
PrintArray(matrix, ind_min_elem);


 
