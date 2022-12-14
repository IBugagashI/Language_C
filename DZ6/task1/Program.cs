//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    Console.WriteLine($"Количество чисел больше 0: {count}");
} 
Console.Clear();
Console.Write("Введите количество чисел для ввода: ");
int M = Convert.ToInt32(Console.ReadLine());
while (M < 1)
{
    Console.Write("!!!Укажите чило больше 0!!! ");
    Console.Write("Введите число заново: ");
    M = Convert.ToInt32(Console.ReadLine());
} 
int[] array = new int[M];
InputArray(array);
Console.WriteLine($"Числа массива: [{string.Join(", ", array)}]");
ReleaseArray(array);