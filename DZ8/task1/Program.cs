// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void FillMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}
void ReleaseMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }   
} 

void OrderlyMatrix(int [,] arr)
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

void ReleaseOrderlyMatrix(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }   
} 


Console.Clear();
Console.Write("Укажите количество строк(m) в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов(n) в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];

FillMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine("Сортированный по убыванию массив:");
OrderlyMatrix(matrix);
ReleaseOrderlyMatrix(matrix);
