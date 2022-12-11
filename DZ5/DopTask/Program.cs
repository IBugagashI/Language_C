// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником. 
// В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а по четным – четверки. 
// Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, чтобы оценить, сколько у него троек и сколько четверок. 
// Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите день получения оценки: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        while (array[i] < 1 || array[i] > 31)
        {
            Console.Write("!!!Нужно число больше 0 и не больше 31!!!\nВведите число заново: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }           
    }
}
void ReleaseArray(int[] array)
{
    int three = 0;//троек получено
    int four = 0;//четвёрок получено
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            four += 1;
        else
            three += 1;
    }
    Console.Write("Дни с тройками: ");
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 1)
        Console.Write(array[j] + " ");        
    }
    Console.Write("\nДни с четвёрками: ");
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        Console.Write(array[j]+ " ");        
    }
    if (four >= three)
    Console.Write("\nYES");
    else
    Console.Write("\nNO");
}
Console.Clear();
Console.Write("Введите количество оценок: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 1 || N > 100)
{
    Console.Write("!!!Нужно число больше нуля и не больше ста!!!\nВведите число заново: ");
    N = int.Parse(Console.ReadLine());
}
int[] array = new int[N];
Array.Sort(array);
InputArray(array);
Console.WriteLine($"Дни с оценками: {string.Join(" ", array)}");
ReleaseArray(array);