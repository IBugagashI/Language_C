// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void ReleaseArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"|{array[i, j]}|");
        }
        Console.WriteLine();
    }   
} 

Console.Clear();
Console.Write("Укажите колличество строк(m) в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите колличество столбцов(n) в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double[m,n];
FillArray(array);
ReleaseArray(array);