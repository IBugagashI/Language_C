Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x >= 1 && x <= 5)//(1 <= x <= 5) 
{
Console.WriteLine("Будний");
}
else if (x == 6 || x == 7)
{
Console.WriteLine("Выходной");
}
else
{
Console.WriteLine("Нет таких");
} 

/* Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5)//(1 <= x <= 5) 
{
Console.WriteLine("Будний");
}
else if (x == 6 || x == 7)
{
Console.WriteLine("Выходной");
}
else
{
Console.WriteLine("Нет таких");
} */