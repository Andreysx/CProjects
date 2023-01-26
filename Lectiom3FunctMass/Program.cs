// Упорядочить массив
// Алгоритм сортировки методом выбора
// 1.Найти пизицию минимального элемента неотсортированной части массива
// 2.Произвести обмен этого значения со значением первой неотсортированной позиции
// 3.Повторять пока есть не отсортированный элементы
 
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };// массив который будем отсортировывать
void PrintArray(int[] array)//метод выводящий массив на экран
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]}");
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)//array.Length - обращение к длинне массива
{
int minPosition = i;// определяем позицию на которую смотрим и запоминаем позицию рабочего элемента
 
for (int j = i + 1; j < array.Length; j++)//блок кода ищет максимальный элемент
{
if (array[j] < array[minPosition]) minPosition = j;//блок кода ищет максимальный элемент
 
}
int temporary = array[i];// простой обмен переменных
array[i] = array[minPosition];// простой обмен переменных
array[minPosition] = temporary;// простой обмен переменных
 
}
 
}
PrintArray(arr);
SelectionSort(arr);
 
PrintArray(arr);
// сделать упорядочивание в обратном порядке