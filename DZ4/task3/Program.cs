//Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю ввести числа и вывести их на экран.
Console.Clear();
Console.WriteLine("Зачем оно вам надо, не ведаю, но сделаем массив из 8 элементов!");
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} число массива: ");
    array[i] = int.Parse(Console.ReadLine());
}
var newArray = string.Join(", ", array);
Console.WriteLine($"Числа вашего массива: {newArray}.");