Console.Clear();
int i = 0;
int max = 0;
int x = 0;
Console.Write("Введите колличество кустов N: ");
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
/* void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}  */
int[] bushes = new int[N];

FillArray(bushes);
//PrintArray(bushes);


do
{
    if ((bushes[^2] + bushes[^1] + bushes[0]) > max) 
    max = bushes[^2] + bushes[^1] + bushes[0];
    else if ((bushes[^1] + bushes[1] + bushes[0]) > max)
    max = bushes[^1] + bushes[1] + bushes[0];
    else if ((bushes[0 + i] + bushes[1 + i] + bushes[2 + i]) > max)
    max = bushes[0 + i] + bushes[1 + i] + bushes[2 + i];
    i++;
} while (i < bushes.Length - 2);

Console.Write($"{max}");