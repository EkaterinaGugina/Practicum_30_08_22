// Ex56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[] FillArraySumStr(int[,] matr)                  //заполнение и печать массива и создание массива из сумм всех строк
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int[] sum_str = new int[matr.GetLength(0)];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);    
            Console.Write($"{matr[i, j]}\t");
            sum_str[i] += matr[i,j];
        }
        Console.WriteLine();
    }
    return sum_str;
}
void MinSumStrArray(int[] array)         // нахождение номера миним.элемента в массиве из сумм строк
{
    int i = 1;
    int min = 0;
    while (i < array.Length)
    {
        if(array[i] < array[min])   min = i; 
        i++;
    }
    Console.WriteLine($"Наименьшая сумма элементов в {i}-й строке");
}   
    
Console.Write("Введите размер матрицы. Укажите количество строк, больше чем одну:  m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("  и столбцов, больше чем один:  n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[] sum_str_array = FillArraySumStr(matrix);
MinSumStrArray(sum_str_array);
