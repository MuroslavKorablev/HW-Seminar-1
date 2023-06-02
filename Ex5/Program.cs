using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = FindThirdDigit(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine($"Третья цифра слева: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Такой цифры нет");
        }
    }

    static int FindThirdDigit(int number)
    {
        int digitCount = CountDigits(number);

        if (digitCount < 3)
        {
            return -1; // Число имеет меньше трех цифр
        }

        int divisor = (int)Math.Pow(10, digitCount - 3);
        int truncatedNumber = number / divisor;

        return truncatedNumber % 10;
    }

    static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
}



