//Ex57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1 СПОСОБ - найти самый> и самый< элементы и циклом от них подсчитать сколько кто встретился раз

// int m = new Random().Next(1, 10);
// int n = new Random().Next(1, 10);
// int[,] array = new int[m, n];
// int max = array[0,0];
// int min = array[0,0];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//         Console.Write($"{array[i, j]}\t");
//         if (array[i, j] > max) max = array[i, j];
//         if (array[i, j] < min) min = array[i, j];
//     }
//     Console.WriteLine();
// }
// for (int z = min; z <= max; z++)
// {
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            if (array[i, j] == z) count++;
//         }
//     }
//     if (count != 0) Console.WriteLine($"'{z}' - {count} раз");

// ВТОРОЙ СПОСОБ - ОБЩИЙ ПОДХОД

bool ValueWasUsed(int number, int[,] matrix)              // Метод, определяющий наличие элемента в массиве
{
    bool numExists = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (number == matrix[i, j])
            {
                numExists = true;
                break;
            }
        }

    }
    if (!numExists) return false;
    else return true;
}
void ShowCountOfRepetitons(int number, int[,] matrix)       // Метод, определяющий количество повторений определенного элемента в массиве
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (number == matrix[i, j]) count++;
        }
    }
    Console.WriteLine($"Элемент {number} встречается {count} раз");
}

var rand = new Random();
int rows = rand.Next(2, 10);
int cols = rand.Next(2, 10);
int[,] numbers = new int[rows, cols];
// FillMatrix(numbers);
// PrintMatrix(numbers);
// Console.WriteLine();

int[,] usedValues = new int[rows, cols];                        // Массив для значений элементов, количество повторений которых мы уже посчитали
bool valueUsed;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        valueUsed = ValueWasUsed(numbers[i, j], usedValues);
        if (!valueUsed)
        {
            ShowCountOfRepetitons(numbers[i, j], numbers);
            usedValues[i, j] = numbers[i, j];
        }
    }
}

// третий способ - мой недоделанный
// int m = new Random().Next(1, 10);
// int n = new Random().Next(1, 10);
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//         Console.Write($"{array[i, j]}\t");
//     }
//     Console.WriteLine();
// }
// преобразуем массив в "одномерный" (второй столбец пока заполним нулями)
// int[,] LineArray(int[,] array) 
// {
//      line_arr = new int[array.GetLength(0)*array.GetLength(1), 2];
//      line_arr[0,0] = 0;
//      int k = 0;
//      while (k < line_array.GetLength(0)) 
//      {
//           for (int i = 0; i < array.GetLength(0); i++)
//           {
//              for (int j = 0; j < array.GetLength(1); j++)
//              {
//                  line_arr[k, 0] = array[i, j];
//                  line_arr[k, 1] = 0;
//                  k++;        
//              }
//           }
//      return line_arr;
//  }
// int count = 0; 
// k = 0;
// int[,] result_array = LineArray(array);
// while (k < result_array.GetLength(0))
// {
//     result_arr[k, 0] = array[k, 0];
//            lines_arr[k, 1] = 0;
//             k++;        
//         }
//      }
//      return lines_arr;
//  }
//      count++;
//      result_arr[k, 1] = count;
    
