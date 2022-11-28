Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
void FillArray(int [] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < N)
    {
        collection[index] = index + 1;
        index++;
    }
}
void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] bushes = new int[N];

FillArray(bushes);
PrintArray(bushes);


//double i = Math.Log(N,2);
//Console.Write($"вывод логорифма {i}");