Console.Write("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 1 && a <= 7)
{
    Console.Write($"{WeekDay(a)}");
}
else
{
    Console.Write("Это число не совпадает c днем недели");
}
bool WeekDay(int num)
{
    if (num == 7 || num == 6)
    {
        Console.Write($"{num} -> Да");
    }
    else
    {
        Console.Write($"{num} -> Нет");
    }
}





