Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x < 100)
{
    Console.WriteLine("третьей цифры нет");
    return;
}
while (x > 999)
{
    x = x / 10;
}
Console.Write(x % 10);