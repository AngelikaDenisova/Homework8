// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.WriteLine("Введите количество строк обоих матриц: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов обоих матриц: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int rows2 = rows1;
int columns2 = columns1;

Console.WriteLine("Матрица 1");

int[,] array1 = new int[rows1, columns1];

for(int i=0; i<array1.GetLength(0); i++)
{
   for(int j=0; j<array1.GetLength(1); j++)
   {
    array1[i, j] = new Random().Next(0, 10);
    Console.Write(array1[i, j] + "\t");

   }
Console.WriteLine();
}

Console.WriteLine("Матрица 2");

int[,] array2 = new int[rows2, columns2];

for(int i=0; i<array2.GetLength(0); i++)
{
   for(int j=0; j<array2.GetLength(1); j++)
   {
    array2[i, j] = new Random().Next(0, 10);
    Console.Write(array2[i, j] + "\t");

   }
Console.WriteLine();
}

Console.WriteLine("Произведение матриц");

int [,] array3 = new int [array1.GetLength(0), array2.GetLength(1)];
for(int i=0; i<array1.GetLength(0); i++)
{
   for(int j=0; j<array2.GetLength(1); j++)
   {
      for (int k = 0; k < array2.GetLength(0); k++)
      {
         array3[i,j] += array1[i,k]*array2[k,j];
      }
   Console.WriteLine(array3[i,j] + "\t");
   }
   Console.WriteLine();
}
