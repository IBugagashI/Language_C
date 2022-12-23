/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SummCount(int M, int N)
{
    int result = M;
    if (M == N) return N;
    result = result + SummCount(M + 1, N);
    return result;
}

Console.Clear();
/* Console.Write("Задайте значения M и N, через пробел: ");
int[] meaning = Console.ReadLine().Splite(" ").Select(x => int.Parse(x)).ToArray(); */
Console.Write("Задайте значения M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значения N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от M до N: {SummCount(M, N)}");