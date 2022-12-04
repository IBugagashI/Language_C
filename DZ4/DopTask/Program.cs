// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Console.Clear();
Console.Write("Введите количество чисел последовательности: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
int[] offsetArray = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите {i + 1} число последовательности: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.Write("Введите число, на значение которого последовательность сдвинется: ");
int K = int.Parse(Console.ReadLine());
if (K > N)
{
    Console.Write("!!!Ваше число превышает колличество элементов последовательности!!!\nВведите число заново: ");
    K = int.Parse(Console.ReadLine());
}
if (K == 0)
{
    Console.Write("!!! Укажите число отличное от 0 !!!\nВведите число заново: ");
    K = int.Parse(Console.ReadLine());
}
if (K > 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i + K >= array.Length)
        {
            offsetArray[i + K - array.Length] = array[i];
        }
        else
        {
            offsetArray[i + K] = array[i];
        }
    }   
    var str = string.Join(", ", offsetArray);
    Console.WriteLine($"Последовательность со сдвигом вправо: {str}");
}
else
{
    for (int j = array.Length - 1; j <= 0; j--)
    {
        offsetArray[j] = array[j];
    }
    var str = string.Join(", ", offsetArray);
    Console.WriteLine($"Последовательность со сдвигом влево: {str}");
}
/* array.Reverse(array, K);               // 21|345
array.Reverse(array + K, N - K); // 21|543
array.Reverse(array, K); */

//var str = string.Join(", ", array);
//Console.WriteLine($"Последовательность со сдвигом: {str}");