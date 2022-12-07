//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
Console.Write("Введите количество чисел массива: ");
int N = int.Parse(Console.ReadLine());
while (N < 1)
{
    Console.Write("!!!Нужно число больше нуля!!!\nВведите число заново: ");
    N = int.Parse(Console.ReadLine());
}
int[] array = new int[N];
int even = 0;
int index = 0;

while (index < array.Length)
{
    array[index] = new Random().Next(100, 999);
    index++;
}
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    even++;
}
Console.WriteLine($"Чисел в массиве: {array.Length}\nЧисла массива: {string.Join(", ", array)}\nЧётных чисел в массиве: {even}");