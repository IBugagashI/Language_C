// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(double [] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.NextDouble() + new Random().Next(-10, 10);
}
void ReleaseArray(double [] array)
{
    double max = array[0], min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    if(min < 0 && max > 0)
    {
        min *= -1;
        Console.WriteLine($"Наибольшее число массива: {max:F2}\nНаименьшее число массива: -{min:F2}\nРазница: {max - min:F2}");
    }
    else
    {
        Console.WriteLine($"Наибольшее число массива: {max:F2}\nНаименьшее число массива: {min:F2}\nРазница: {max - min:F2}");
    }
}
Console.Clear();
Console.Write("Введите количество чисел массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double [N];
InputArray(array);
Console.WriteLine($"Числа массива: [{string.Join(" | ", array)}]");
ReleaseArray(array);