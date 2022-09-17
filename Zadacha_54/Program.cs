// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

Console.WriteLine("Первоначальный массив:");

for(int i=0; i<array.GetLength(0); i++)
{
   for(int j=0; j<array.GetLength(1); j++)
   {
    array[i, j] = new Random().Next(0, 10);
    Console.Write(array[i, j] + "\t");

   }
Console.WriteLine();
}

Console.WriteLine("Упорядочили по убыванию:");


for(int i=0; i<array.GetLength(0); i++)
{
   for(int j=0; j<array.GetLength(1); j++)
   {
    for(int k = 0; k < array.GetLength(1)-1; k ++)
    {
      if(array[i,k+1] > array[i, k])
      {
         int temp = array[i,k];
         array[i,k] = array[i,k+1];
         array[i,k+1] = temp;
      }

    }
   Console.Write(array[i,j] + "\t");

   }
Console.WriteLine();
}
