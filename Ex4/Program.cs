﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SN = 2; 

if(N > 1)
{
    while(SN <= N)
    {
        System.Console.WriteLine(SN + " ");
        SN = SN + 2;
    }
}