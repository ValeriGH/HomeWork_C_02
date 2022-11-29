// Дана последовательность натуральных чисел. Найти второй максимум
Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int firstMax = n;
int secondMax = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > firstMax)
    {
        secondMax = firstMax;
        firstMax = n;
    }
    else if (n > secondMax)
    {
        secondMax = n;
    }
}
Console.Write(secondMax);