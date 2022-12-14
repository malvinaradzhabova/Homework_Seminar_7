/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* 
void FillArrayRandomNumbers(double[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1);j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-1000,1000))/10;

        }
    }
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
         for(int j=0; j < array.GetLength(1); j++ )
         {
             Console.Write(array [i,j] + " ");
         }
  
   Console.WriteLine();   
    }
}


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,]numbers=new double[rows,columns];


FillArrayRandomNumbers(numbers);
PrintArray(numbers);

 */
      
     



/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */



/* 
Console.WriteLine("Введите номер строки: ");
int NumberOfRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int NumberOfColumn = Convert.ToInt32(Console.ReadLine());
int[,]numbers=new int[10,10];


void FillArrayRandomNumbers(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100)/10;

        }
    }
}

if (NumberOfRow > numbers.GetLength(0) || NumberOfColumn> numbers.GetLength(1))
    {
        Console.WriteLine("Элемента в двумерном массиве нет");
    }
else
    {
        Console.WriteLine($"Значение элемента строки и столбца = {numbers[NumberOfRow-1,NumberOfColumn-1]}");
    }

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
         for(int j=0; j < array.GetLength(1); j++ )
         {
             Console.Write(array [i,j] + " ");
         }
  
   Console.WriteLine();   
    }
}

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

 */


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

 
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,]numbers=new int[rows,columns];
FillArrayRandomNumbers(numbers);

for(int j = 0; j < numbers.GetLength(1); j++)
{
    double average = 0;
    for(int i = 0; i<numbers.GetLength(0); i++)
    {
        average = (average + numbers[i,j]);
    }
    average = average/rows;
    Console.Write(average + "; ");
}
Console.WriteLine();
PrintArray(numbers); 


void FillArrayRandomNumbers(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(0,10);

        }
    }
}


void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
         for(int j=0; j < array.GetLength(1); j++ )
         {
             Console.Write(array [i,j] + " ");
         }
  
   Console.WriteLine();   
    }
}






