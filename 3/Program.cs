               
int Akerman(int n, int m)
    {
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akerman(n - 1, 1);
    if (n > 0 && m > 0) return Akerman(n - 1, Akerman(n, m - 1));
    return Akerman(n,m);
    }
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akerman(n, m));