/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = FillArray(length);
Console.WriteLine($"{CounterPositive(array)} чисел больше нуля");


int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1}ый элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int CounterPositive(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            counter++;
        }
    }
    return counter;
}