using System;

public class AverageCalculus
{
    public static void Main(String[] args)
    {
    	Console.WriteLine("Welcome to AverageCalc");
    	Console.WriteLine("");
    	Console.WriteLine("Enter first number: ");
    	int q = Convert.ToInt32(Console.ReadLine());
    	Console.WriteLine("Enter second numnber: ");
    	int w = Convert.ToInt32(Console.ReadLine());
    	Console.WriteLine("Enter third number: ");
    	int e = Convert.ToInt32(Console.ReadLine());
    	Console.WriteLine("Enter fourth number: ");
    	int r = Convert.ToInt32(Console.ReadLine());
    	Console.WriteLine("Enter fifth number: ");
    	int t = Convert.ToInt32(Console.ReadLine());

    	int y = (q + w + e + r + t) / 5;

    	Console.WriteLine("Results: ");
    	Console.WriteLine(y);
    }
}