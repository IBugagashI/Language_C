//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Ведите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

/* var x = (b2 - b1) / (k2 - k1); 
var y = k1 * x + b1; */

var x = (b1 - b2) / (k2 - k1);
var y = k1 * x + b1;

Console.Write($"Пересечение в точке: ({x};{y})");