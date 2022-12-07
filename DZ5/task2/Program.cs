// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}
void ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма нечётных позиций массива: {sum}");
}
Console.Clear();
Console.Write("Введите количество чисел массива: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
InputArray(array);
Console.WriteLine($"Числа массива: {string.Join(", ", array)}");
ReleaseArray(array);