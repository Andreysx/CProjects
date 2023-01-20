//Задача 15 Напишите программу 
//которая принимает на вход цифру обозначающую день недели и 
//проверяет является ли этот день выходным
//6->да
//7->да
//1->нет

//Console.Write("Введите число от 1 до 7: ");
//int a = Convert.ToInt32(Console.ReadLine());

//if (a == 6 && a == 7)
//   Console.WriteLine($"{WeekDay(a)} -> Да");
//else
//  Console.WriteLine($"{WeekDay(a)} -> Нет");
Console.Write("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

WeekDay(a);


int WeekDay(int num)
{
    if (num >= 1 && num <= 7)
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

    else
    {
        Console.Write("Это число не совпадает c днем недели");
    }

    return num;
}