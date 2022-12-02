// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Console.Clear();
Console.Write("Введите количество чисел последовательности: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
int[] offsetArray = new int[N];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} число последовательности: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.Write("Введите число, на значение которого последовательность сдвинется: ");
int K = int.Parse(Console.ReadLine());
if (K > N)
{
    Console.Write("!!!Ваше число превышает колличество элементов последовательности!!! \n Введите число заново: ");
    K = int.Parse(Console.ReadLine());
}
if (K > 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        offsetArray[i] = (i + K) % array.Length;
    }   
    var str = string.Join(", ", offsetArray);
    Console.WriteLine($"Последовательность со сдвигом вправо: {str}");
}
else
{

    
    var str = string.Join(", ", array);
    Console.WriteLine($"Последовательность со сдвигом влево: {str}");
}
/* array.Reverse(array, K);               // 21|345
array.Reverse(array + K, N - K); // 21|543
array.Reverse(array, K); */

//var str = string.Join(", ", array);
//Console.WriteLine($"Последовательность со сдвигом: {str}");