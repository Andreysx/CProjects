//Задача 10 Напишите программу которая 
//принимает на вход трехзначное число
//и на выходе показывает вторую цифру этого числа.
//456->5
//782->8
//918->1

//if(number / 1000 == 0)
//{
//Console.WriteLine($"Ваше трехзначное число = {number}");  
//} 
//else 
//{
//   Console.WriteLine($"{number} = Это не трехзначное число");
//}


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <= 999)
    Console.WriteLine($" Вторая цифра числа -> {SecondNumber(number)}");
else
    Console.WriteLine("Вы ввели не трехзначное число");

//int res = SecondNumber(number);
//Console.WriteLine($"Вторая цифра этого числа -> {res}");

int SecondNumber(int numb)
{
    int num1 = number / 10;
    int num2 = num1 % 10;
    int result = num2;
    return result;
}



