// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число m = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n = ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 >= 0 && number2 >= 0)
{

    int result = AkkermanFunction(number1, number2);
    Console.WriteLine($"m = {number1}, n = {number2} -> A({number1},{number2}) = {result}");

}
else Console.WriteLine("Введено некорректное значение.");

int AkkermanFunction(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    else if (num1 > 0 && num2 == 0)
        return AkkermanFunction(num1 - 1, 1);
    else if (num1 > 0 && num2 > 0)
        return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
    else
        return AkkermanFunction(num1, num2);

}

// int AkkermanFunction(int num1, int num2) более оптимизированное решение
// {
//     if (num1 == 0)
//         return num2 + 1;
//     else if (num1 > 0 && num2 == 0)
//         return AkkermanFunction(num1 - 1, 1);
//         return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
//    
// }