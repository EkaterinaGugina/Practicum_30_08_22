// Ex54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] FillArray1(int[,] matr)                   //заполнение и печать массива
{
    int[,] matrix = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-10, 10);    
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    return  matrix;
}

void SeachPosition(int[,] matr, int pos)       //поиск элемента по индексу
{
    int a = pos / 10;
    int b = pos % 10;
    if (a >= matr.GetLength(0) || b >= matr.GetLength(1))
    {
        Console.Write($"Такого элемента в матрице размера {matr.GetLength(0)}x{matr.GetLength(1)} нет");
    }
    else
    {
        Console.Write($"Элемент в {a + 1}-той строке и {b + 1}-том столбце равен {matr[a, b]}");
    }
}
Console.WriteLine("Создаем матрицу. Количество строк m и столбцов n будут случайными, но не более 10");
int m1 = Convert.ToInt32(new Random().Next(1, 10));
int n1 = Convert.ToInt32(new Random().Next(1, 10));
int[,] array = new int[m1, n1];
int[,] matrix1 = FillArray1(array);
Console.WriteLine();
Console.WriteLine("Какой элемент вы хотели бы найти? Введите индекс в формате ab, где a - номер строки,  b - номер столбца, с учетом, что нумерация идет с '0'");
int position = Convert.ToInt32(Console.ReadLine());
SeachPosition(matrix1, position);

 
