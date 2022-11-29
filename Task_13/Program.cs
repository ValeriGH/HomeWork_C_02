// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    int rever = 0;
    while (num > 99)
    {
        rever = rever * 10 + num % 10;
        num /= 10;
        //Console.WriteLine(rever);
    }
    Console.WriteLine(rever % 10);
}