// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Clear();
int n = int.Parse(Console.ReadLine());
while (n <1 || n > 8) 
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1) Console.Write("нет");
else if (n == 2) 
    Console.Write("нет");
else if (n == 3) 
    Console.Write("нет");
else if (n == 4) 
    Console.Write("нет");
else if (n == 5) 
    Console.Write("нет");
else if (n == 6) 
    Console.Write("Выходной");
else    Console.Write("Выходной");