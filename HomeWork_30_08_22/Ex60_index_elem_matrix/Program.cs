// Ex60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.//
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void FillArray(int[, ,] matr)                  
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = new Random().Next(10, 100);    
                Console.Write($"{matr[i, j, k]}({i}{j}{k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[, ,] matrix = new int[2, 2, 2];
FillArray(matrix);




 int[] GetUniqueSequencesWithMix(
      int count, 
      int startValue = 10)
 {
  int[] set = new int[count]; 
  int size = set.Length; 
  for (int i = 0; i < size; i++)
   set[i] = startValue + i;

  for (int i=0; i<size-1; i++)
  {
   int pos = Random.Shared.Next(i + 1, size);
   (set[i], set[pos]) = (set[pos], set[i]);
  } 
 return set; 
}