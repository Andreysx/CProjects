//Задача 13 Напишите программу которая 
//выводит третью цифру заданного числа 
//или сообщает что третьей цифры нет.
//645-> 5
 //78-> третьей цифры нет
 //32769 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
    Console.WriteLine($" Третья цифра числа {number} -> {NumberThree(number)}");
else
    Console.WriteLine("Третьей цифры нет");


int NumberThree(int num)
{
    while(number >= 999)
    {
        number = number / 10;
    }
    int num1 = number % 10;
    int result = num1;
    return result;
}
