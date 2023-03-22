int min = 0;
int max = 0;

System.Console.WriteLine("Ведите первое число");
int firstN = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ведите второе число");
int secondN = Convert.ToInt32(Console.ReadLine());

if(firstN > secondN)
{
    min = secondN;
    max = firstN;
}
else
{
  min = firstN;
  max = secondN;  
}
//System.Console.WriteLine($"{max} > {min} = {max = }"); не правильно
System.Console.WriteLine("max = " + max + " и " + "min = " + min);
