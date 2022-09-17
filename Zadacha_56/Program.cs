// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows,columns];
int temp = int.MaxValue;
int k = 0;
int sum = 0;

Console.WriteLine("Массив:");

if (rows != columns)
{
  for(int i=0; i<array.GetLength(0); i++)
  {
     for(int j=0; j<array.GetLength(1); j++)
     {
      array[i, j] = new Random().Next(0, 10);
      Console.Write(array[i, j] + "\t");

     }
   Console.WriteLine();
   }

   for(int i=0; i<array.GetLength(0); i++)
   {
     for(int j=0; j<array.GetLength(1); j++)
     {
     sum += array[i,j]; 
     }
   Console.WriteLine("Сумма элементов строки равна:" + sum);
     if (temp > sum)
     {
     temp = sum;
     k = i;
     }
   }  
   Console.WriteLine("Номер строки с наименьшей суммой элментов :" + k);
}
else
{
  Console.WriteLine("Массив не прямоугольный");
}