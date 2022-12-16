// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.
Console.Clear();

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
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
void TranspositionArray(int [,] array)
{
    for (int i = array.GetLength(0) - 1; i >= 0 ; i--)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
} 


Console.Write("Укажите количество строк(N) в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов(M) в массиве: ");
int M = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[N, M];

FillArray(array);
ReleaseArray(array);
Console.WriteLine("\nТранспонированный\n");
TranspositionArray(array);