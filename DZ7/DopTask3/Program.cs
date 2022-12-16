void FillArray(int [,] array)
{   
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (x % 2 != 0 & x < array.GetLength(0))
            array[i, j] = x;
            else if (x >= array.GetLength(0))
            array[i, j] = x + array.GetLength(0);
            else
            array[i, j] = x;
            x++;
        }
    }
}
void ReleaseArray(int [,] array)
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
Console.Write("Укажите количество строк(m) в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов(n) в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[m, n];
FillArray(array);
ReleaseArray(array);
