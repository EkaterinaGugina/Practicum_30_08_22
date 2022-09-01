// Ex56: Задайте прямоугольный двумерный массив. Программа считает сумму элементов в каждой 
//строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[] FillArraySumStr(int[,] matr)       //создание массива из сумм всех строк
{
    int[] sum_str = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
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
void NumMinArray(int[] array)      // нахождение номера миним.элемента в массиве из сумм строк
{
    int index_min = 0;
    int i = 1;
    while (i < array.Length)
    {
        if(array[i] < array[index_min])   index_min = i; 
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
NumMinArray(sum_str_array);
