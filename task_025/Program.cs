/*
    Задача 25: Напишите цикл, который принимает на вход два числа 
    (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/

//Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа: ");
int degreeOf = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(degreeOf, number);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{number} в степени {degreeOf} = {result}");
Console.ResetColor();

int Exponentiation(int degreeOf, int number)
{
    int result = 1;
    for (int i = 0; i < degreeOf; i++)
    {
        result = result * number;
    }
    return result;
}
