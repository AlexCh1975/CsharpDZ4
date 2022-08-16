/*
    Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int indexNumber = GetIndexNumber(number);

int summa = TheSumOfTheDigitsOfANumber(number, indexNumber);
PrintSumma(summa);

// Определяем скольки значное число
int GetIndexNumber(int number)
{
    int indexNumber = 1;
    while (true)
    {
        number = number / 10;
        indexNumber++;
        if (number < 10)
        {
            break;
        }
    }
    return indexNumber;
}


// Вычислят сумму чисел числа
int TheSumOfTheDigitsOfANumber(int number, int indexNumber)
{
    int degreeOf, separateNumber;
    int summa = 0;
    int index = indexNumber;
    for (int i = 0; i < index; i++)
    {
        separateNumber = SplitANumberIntoSeparateNumbers(number, indexNumber); 
        degreeOf = DegreeOf(indexNumber);
        number = number - separateNumber * degreeOf;
        summa = summa + separateNumber;
        indexNumber--;
    }
    return summa;
}

// Разбиваем число на отдельные числа
int SplitANumberIntoSeparateNumbers(int number, int indexNumber)
{
    for (int i = 0; i < indexNumber -1; i++)
    {
        number = number / 10;
    }
    return number;
}

// 10 в степени IndexNumber
 int DegreeOf(int indexNumber)
{  
    int result = 1;
    while(indexNumber-1 != 0)
    {
        result = result*10;
        indexNumber--;
    }
    return result;
}

// Вывод суммы
void PrintSumma(int summa)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Сумма чисел числа {number} = {summa}");
    Console.ResetColor();
}