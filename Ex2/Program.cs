int max = 0;

System.Console.WriteLine("ведите первое число");
int firstN = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ведите второе число");
int secondN = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ведите третье число");
int thirdN = Convert.ToInt32(Console.ReadLine());

if(firstN > max)
{
    max = firstN;

}
if (secondN > max)
{
    max = secondN;
}

if (thirdN > max)
{
    max = thirdN;
}

System.Console.WriteLine("max = " + max);
