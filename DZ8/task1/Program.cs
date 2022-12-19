// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void ReleaseArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }   
} 

void OrderlyArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int x;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(0); k++)
            if (arr[i,k] > arr[i,j])
            {
            x = arr[i,j];
            arr[i, j] = arr[i,k];
            arr[i, k] = x; 
            }
        }
    }
}

void ReleaseOrderlyArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }   
} 


Console.Clear();
Console.Write("Укажите количество строк(m) в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов(n) в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[m,n];

FillArray(array);
ReleaseArray(array);
Console.WriteLine("Сортированный массив по убыванию:");
OrderlyArray(array);
ReleaseOrderlyArray(array);