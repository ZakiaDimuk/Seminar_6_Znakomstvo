// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите кол-во чисел: ");
int M = int.Parse(Console.ReadLine()!);
int[] array = new int[M];

void Massive(int M)
{
    for (int i = 0; i < M; i++)
    {
    Console.WriteLine($"Введите {i+1} элемент массива");
    array[i] = int.Parse(Console.ReadLine()!);
    }
}

int Count(int[] array)
{
    int kol = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            kol++;
        }
    }
    return kol;
}

Massive(M);
Console.Write($"Количество чисел > 0 = {Count(array)}");