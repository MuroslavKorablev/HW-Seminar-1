//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int revDiv = 2; 

if(number > 1)
{
    while(revDiv <= number)
    {
        System.Console.WriteLine(revDiv + " ");
        revDiv = revDiv + 2;
    }
}