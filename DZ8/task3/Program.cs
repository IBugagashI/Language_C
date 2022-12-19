// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void FillMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 4);
        }
    }
}
void ReleaseMatrix(int [,] matrix)
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
void ProductMatrix(int [,] matrix1, int[,] matrix2, int[,] product)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < product.GetLength(1); k++)
            {
                sum += matrix1[i,k] * matrix2[k,j];
            }
            product[i,j] = sum;
        }        
    }
}

Console.Clear();
Console.Write("Задайте значение матриц, через пробел: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();//запрос у пользователя количества строк(первое значение) и столбцов(второе значение) через пробел
int[, ] matrix1 = new int[coord[0], coord[1]];
int[, ] matrix2 = new int[coord[0], coord[1]];
int[, ] product = new int[coord[0], coord[1]];

/* Console.Write("Задайте значение первой матрицы, через пробел: ");
int[] coordM1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix1 = new int[coordM1[0], coordM1[1]];
Console.Write("Задайте значение второй матрицы, через пробел: ");
int[] coordM2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix2 = new int[coordM2[0], coordM2[1]];
int[, ] product = new int[coordM1[0], coordM2[1]]; */

FillMatrix(matrix1);
ReleaseMatrix(matrix1);
Console.WriteLine();
FillMatrix(matrix2);
ReleaseMatrix(matrix2);
Console.WriteLine("Произведение двух матриц");
ProductMatrix(matrix1, matrix2, product);
ReleaseMatrix(product);