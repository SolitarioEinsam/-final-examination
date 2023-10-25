int SumCounts (int m, int n)
{
    int result = 0;
    for (int i = m; i <= n; i ++)
    {
        result += i;
    }
    return result;
}

Console.Clear();
System.Console.Write("Введите начальное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Clear();
System.Console.Write("Введите конечное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write($"Сумма всех натуральных чисел в промежутке между [{m}, {n}] = {SumCounts(m, n)}");

