//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine());
int result = 1;
for(int i = 1; i <= B; i++)
{
    result = result * A;
}
Console.WriteLine($"Степенть числа А: {result}");