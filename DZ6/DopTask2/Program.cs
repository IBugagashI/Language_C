// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.
Console.Clear();
Console.Write("Ведите значение x1: ");
var x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите значение y1: ");
var y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите значение x2: ");
var x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите значение y2: ");
var y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите значение x3: ");
var x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите значение y3: ");
var y3 = Convert.ToDouble(Console.ReadLine());

var x = (x2 - x1)*(y3 - y1) - (x3 - x1)*(y2 - y1);
/* Double A = Math.Sqrt((x2-x1) + (y2-y1));
Double B = Math.Sqrt((x3-x2) + (y3-y2));
Double C = Math.Sqrt((x1-x3) + (y1-y3)); */

/* double A = Math.Sqrt((x2-x1)*2 + (y2-y1)*2);
double B = Math.Sqrt((x3-x1)*2 + (y3-y1)*2);
double C = Math.Sqrt((x2-x3)*2 + (y2-y3)*2); */

Console.Write($"Площадь (S) треугольника: {Math.Round(Math.Abs(x) / 2, 1)}");