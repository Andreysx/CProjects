// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
//  3 -> 11
// 2->10
int NumBinary(int number)
{
    int numberBin = 0;
    int count = 1;
    while (number > 0)
    {
        numberBin = numberBin + (number % 2 * count);
        number /= 2;
        count *= 10;
    }
    return numberBin;
}

Console.Write("Введите число: ");
int num;
if (int.TryParse(Console.ReadLine(), out num))//ПРОВЕРКА НА ПРАВИЛЬНОСТЬ ВВОДА
{
    if(num >= 0)
    {
    int result = NumBinary(num);
    Console.WriteLine(result);
    }
    else Console.WriteLine("Введено отрицательное значение");
}
else Console.WriteLine("Введено некорректное значение");


// int NumBinary(int number)РЕШЕНИЕ БЕЗ ПРОВЕРКИ
// {
//     int numberBin = 0;
//     int count = 1;
//     while (number > 0) 
//     {
//         numberBin = numberBin + (number % 2 * count);РЕШЕНИЕ БЕЗ ПРОВЕРКИ
//         number /=2;
//         count*=10;
//     }
//     return numberBin;
// }

// Console.Write("Введите число: ");РЕШЕНИЕ БЕЗ ПРОВЕРКИ
// int num = Convert.ToInt32(Console.ReadLine());
// int result = NumBinary(num);
// Console.WriteLine(result);






