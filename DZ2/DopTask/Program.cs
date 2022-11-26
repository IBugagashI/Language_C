Console.Clear();
int x;
int i = 0;
int z = 0;
do
{
    x = int.Parse(Console.ReadLine());
    if (x > i)
    z = i;
    i = x;
} 
while (x != 0);
Console.WriteLine($"Второе максимальное число: {z}");