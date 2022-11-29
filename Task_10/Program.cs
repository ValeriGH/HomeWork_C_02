// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

while (n < 100 || n > 1000)
{
    Console.Write("Ошибка!\nВведите трехзначное число: ");
    n = int.Parse(Console.ReadLine());
}
Console.Write($"Вторая цифра числа: {n / 10 % 10}");