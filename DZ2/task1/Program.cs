Console.Clear();
while(true)
{
    Console.Write("Введите трёхзначное число: ");
    int x = int.Parse(Console.ReadLine());
    if (x < 100 | x > 999)
    {
        Console.WriteLine("Ц, ц, ц !!! Нужно трёхзначное число");
    }
    else
    {
        Console.Write((x / 10) % 10);
        break;
    }
}
// как "бороться" с буквами, я не соображу