//Задача 6:Напишите программу которая на вход принимает число и выдает
//является ли число четным(делится на 2 без остатка)
 
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
