//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void ElementArray(int [, ] array, int x, int y)
{
    if (x > array.GetLength(0) || y > array.GetLength(1))
        Console.WriteLine("Нет такого элемента");
    else
    {
        Console.WriteLine($"Элемент {x} строки и {y} столбца: {array[x-1 , y-1]}");
    }
} 

Console.Clear();
Console.Write("Укажите количество строк(m) в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов(n) в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите строку(m) выводимого элемента: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите столбец(n) выводимого элемента: ");
int y = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[m,n];
FillArray(array);
ReleaseArray(array);
ElementArray(array, x, y);