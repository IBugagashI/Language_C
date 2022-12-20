﻿//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

//[страници, строки, колонки]

void FillArray(int [,,] array)
{
    int number = 10;
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++) array[i,j,k] = number++;
        }
    }
}
void ReleaseArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        Console.WriteLine($"Старница {i+1}");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
                
        }
    }   
}

Console.Clear();
Console.Write("Задайте значение массива, через пробел: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] array = new int[coord[0], coord[1], coord[2]];

FillArray(array);
ReleaseArray(array);
Console.WriteLine();
Console.Write(array[1,0,1]);//проверка индекса