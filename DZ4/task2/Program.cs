// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int victim = number;
int sum = 0;
//for(int i = 0; number != 0; i++)
while (victim > 0)
{
    sum += victim % 10;
    victim /= 10;
}
Console.WriteLine($"Суммой чисел, числа {number}, является {sum}");