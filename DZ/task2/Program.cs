Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int z = int.Parse(Console.ReadLine());
int i = x;
if (i < y) i = y;
if (i < z) i = z;
Console.Write("max = " + i);

// второе решение(не нравится)
//if (x > y)
//{
// if (x > z)
//    {
// Console.Write("max = " + x);
//    }
// else
//    {
// Console.Write("max = " + z);
//    }
//}
//else if (y > z)
//{
// Console.Write("max = " + y);
//}
//else
//{
// Console.Write("max = " + z);
//}

// первое решение(не удачное)
//if (x > y && x > z)
//{
//    Console.Write("max = " + x);
//}
//else if (y > x && y > z)
//{
//    Console.Write("max = " + y);
//}
//else if (z > x && z > y)
//{
//    Console.Write("max = " + z);
//}