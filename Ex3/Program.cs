﻿Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine(number +" Является натуральным числом");
}
else
{
    Console.WriteLine(number + " Не является натуральным");
}
