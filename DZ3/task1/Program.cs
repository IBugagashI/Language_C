Console.Clear();
Console.Write("Введите пятизначное число: ");
while (true)
{
    int x = int.Parse(Console.ReadLine());
    if (x < 10000)
    {
        Console.WriteLine("!!!Нужно пятизначное число!!!");
        Console.Write("Введите пятизначное число: ");
    }
    else
    {
        if ((x / 10000) == (x % 10) & ((x / 1000) % 10 == (x / 10) % 10))
        Console.Write("Да");
        else
        Console.Write("Нет");
        break;
    }
}