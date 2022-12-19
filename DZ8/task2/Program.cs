// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FillMatrix(int [,] matrix)//заполнение матрици/массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}
void ReleaseMatrix(int [,] matrix)//вывод матрици/массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }   
}
void SumStringsMatrix(int [,] matrix)//Сумма элементов строки
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма элементов строки {i + 1}: {sum}");
    }
}
void StringMinSumMatrix(int [,] matrix)// поиск строки с наименьшей суммой
{
    int MinSum = 0;
    int str = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (MinSum >= sum)
        {
            MinSum = sum;
            str = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке: {str + 1}");
}

Console.Clear();
Console.Write("Задайте значение прямоугольного двумерного массив, через пробел: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();//запрос у пользователя количества строк(первое значение) и столбцов(второе значение) через пробел
int[, ] matrix = new int[coord[0], coord[1]];

FillMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine();
SumStringsMatrix(matrix);
Console.WriteLine();
StringMinSumMatrix(matrix);