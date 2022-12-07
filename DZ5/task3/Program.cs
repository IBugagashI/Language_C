// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
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
        Console.WriteLine($"Наибольшее число массива: {max}\nНаименьшее число массива: -{min}\nРазница: {max - min}");
    }
    else
    {
        Console.WriteLine($"Наибольшее число массива: {max}\nНаименьшее число массива: {min}\nРазница: {max - min}");
    }
}
Console.Clear();
Console.Write("Введите количество чисел массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double [N];
InputArray(array);
Console.WriteLine($"Числа массива: {string.Join(", ", array)}");
ReleaseArray(array);