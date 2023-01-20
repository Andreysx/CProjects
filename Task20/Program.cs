//Задача 22: Напишите программу, 
//которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5} -> {count * count,5}");// 5- форматирование строки
        count++;
    }

}
SquareTable(number);


//Console.WriteLine("Введите число "); РЕШЕНИЕ ЗАДАЧИ ЧЕРЕЗ ЦИКЛ FOR
//int number = Convert.ToInt32(Console.ReadLine());РЕШЕНИЕ ЗАДАЧИ ЧЕРЕЗ ЦИКЛ FOR

//void Square(int num)РЕШЕНИЕ ЗАДАЧИ ЧЕРЕЗ ЦИКЛ FOR
//{
 //   for (int i = 1; i <= num; i++)РЕШЕНИЕ ЗАДАЧИ ЧЕРЕЗ ЦИКЛ FOR
  //  {
  //      Console.WriteLine($"{i} -> {i * i}");РЕШЕНИЕ ЗАДАЧИ ЧЕРЕЗ ЦИКЛ FOR
  //  }
//}РЕШЕНИЕ ЗАДАЧИ ЧЕРЕЗ ЦИКЛ FOR
///Square(number);РЕШЕНИЕ ЗАДАЧИ ЧЕРЕЗ ЦИКЛ FOR