// Задача 2: Напишите программу, 
//которая на вход принимает два числа и выдает, 
//какое число больше, а какое меньше.

Console.Write("Введите первое целое число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число A больше второго числа B");

}
else
{
    Console.WriteLine("Второе число A больше числа B");

}