/*
    Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    (на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)
    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();


Console.WriteLine("Создание массива.");
Console.Write("Введите число элементов массив: ");
int elementCount = int.Parse(Console.ReadLine());
int[] array = new int[elementCount];
int[] resultArray  = CreateArray(array);
PrintArray(resultArray);


int[] CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива: {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[ ");
    for (int i = 0; i<= array.Length -1; i++)
    {
        if (i == array.Length -1)
        {
           Console.Write($"{array[i]} "); 
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine("]");
    Console.ResetColor();
}
