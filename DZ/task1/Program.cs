Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
if (x > y)
{
    Console.Write("max = " + x);
}
else
{
    Console.Write("max = " + y);
}