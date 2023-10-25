
void FillNaturalCount(int count)
{
    if (count > 0)
    {
    Console.Write($"{count} ");
    count --;
    FillNaturalCount(count);
    }
}


Console.Write("Пожалуйста введите число: ");
int count = Convert.ToInt32(Console.ReadLine());

FillNaturalCount(count);
