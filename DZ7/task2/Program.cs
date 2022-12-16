//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

/*void ElementArray(int x, int y)
{
    if (x > m || y > n)
        Console.WriteLine("Нет такого элемента");
    else
    {
        Console.WriteLine($"Элемент {m} строки и {n} столбца: {array[x , y]}");
    }
} */

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

if (x > m || y > n)
    Console.WriteLine("Нет такой позиции");
else
{
    Console.WriteLine($"Элемент {m} строки и {n} столбца: {array[x , y]}");
}
//ElementArray(x, y);