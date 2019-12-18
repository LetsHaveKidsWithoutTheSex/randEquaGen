using System;

public class codeKatas
{
    public static void Main(String[] args)
    {

    	// Fahrenheit > Celsius formula == (n°F - 32) * 5/9 = x°C
    	// Fahrenheit > Kelvin formula == (n°F − 32) × 5/9 + 273.15 = x°K
    	// Celsius > Fahrenheit formula == (n°C × 9/5) + 32 = x°F
    	// Celsius > Kelvin formula == n°C + 273.15 = x°K
    	// Kelvin > Celsius formula == n°K − 273.15 = -x°C
 		// Kelvin > Fahrenheit formula == (n°K − 273.15) × 9/5 + 32 = -x°F


    	Console.WriteLine("Welcome to TempConverter2.1.12-0");
    	Console.WriteLine("Convert from?: Celsius, Fahrenheit, Kelvin");
    	string temperature = Console.ReadLine();
    	int degrees;

    	if (temperature == "Celsius")
    		{
    			Console.WriteLine("Convert Celsius into: Kelvin, Fahrenheit");
    			string sCelsius = Console.ReadLine();

    			if (sCelsius == "Kelvin")
    			{
    				Console.WriteLine("Enter amount to convert: ");
    				int cDegrees = Convert.ToInt32(Console.ReadLine());

    				int kToCMaths = kDegrees - //TODO
    			}

    			else if (sCelsius == "Fahrenheit")
    			{
    				Console.WriteLine("Enter amount to convert: ");
    				int fDegrees = Convert.ToInt32(Console.ReadLine());
    			}
    			else {
    				Console.WriteLine("Error");
    			}
    			

    		}
    	else if (temperature == "Fahrenheit")
    		{
    			Console.WriteLine("Convert Fahrenheit into: Kelvin, Celsius");
    			degrees = Convert.ToInt32(Console.ReadLine());

    		}
    	else if (temperature == "Kelvin")
	    	{
	    		Console.WriteLine("Convert Kelvin into: Celsius, Fahrenheit");
	    		degrees = Convert.ToInt32(Console.ReadLine());
	    	}
    	else
	    	{
	    		Console.WriteLine("Error try again");
	    	}

    }
}