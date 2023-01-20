//Задача 18: Напишите программу, 
//которая по заданному номеру четверти,
// показывает диапазон
//возможных координат точек в этой четверти (x и y).


Console.Write("Введите номер четверти: ");
string a = Console.ReadLine()!;// ! - информационное значение

string range = Range(a);
Console.WriteLine(range);

string Range(string num) //string метод возвращает строку в начале метода указываем тип возвращаемого значения(в нашем случае string)
{
    if (num == "1") return "x > 0 и y > 0";
    if (num == "2") return "x < 0 и y > 0";
    if (num == "3") return "x < 0 и y < 0";
    if (num == "4") return "x > 0 и y < 0";
    return ("Введите некорректные данные");
}



