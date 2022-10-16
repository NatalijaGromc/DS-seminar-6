// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array;

int[] CreateArray()
{
int M;
string userEnter;
Console.Write($"Введите количество элементов массива: ");
int.TryParse(Console.ReadLine()!, out M);
int[] _array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите элемент номер {i} ");
    userEnter = Console.ReadLine()!;
    _array[i] = int.Parse(userEnter);
}
return _array;
}
array = CreateArray();

int count = 0;

foreach (var item in array)
{
    if (item > 0)
count++;
}
Console.Write($"{count}");