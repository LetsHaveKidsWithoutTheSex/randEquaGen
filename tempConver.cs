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
        //string exit = Console.ReadLine();
        while (1 == 1) {
        Console.WriteLine("Welcome to TempConverter2.1.12-0");
        Console.WriteLine("Convert from?: Celsius, Fahrenheit, Kelvin");
        string temperature = Console.ReadLine();

        if (temperature == "Celsius")
            {
                Console.WriteLine("Convert Celsius into: Kelvin, Fahrenheit");
                string celS = Console.ReadLine();


                if (celS == "Kelvin")
                {
                    // Celsius > Fahrenheit formula == (n°C × 9/5) + 32 = x°F
                    // Celsius > Kelvin formula == n°C + 273.15 = x°K
                    Console.WriteLine("Amount: ");
                    double celSi = Convert.ToDouble(Console.ReadLine());
                    double conv = celSi + 273.15;
                    Console.WriteLine(conv);
                }

                else if (celS == "Fahrenheit")
                {
                    // Celsius > Kelvin formula == n°C + 273.15 = x°K
                    // Celsius > Fahrenheit formula == (n°C × 9/5) + 32 = x°F
                    Console.WriteLine("Enter amount to convert: ");
                    double celSi = Convert.ToDouble(Console.ReadLine());
                    double conv = (celSi * 9/5) + 32;
                    Console.WriteLine(conv);
                }
                else {
                    Console.WriteLine("Did you misspell a word?");
                }
                

            }
        else if (temperature == "Fahrenheit")
            {   // Fahrenheit > Celsius formula == (n°F - 32) * 5/9 = x°C
                // Fahrenheit > Kelvin formula == (n°F − 32) × 5/9 + 273.15 = x°K
                Console.WriteLine("Convert Fahrenheit into: Kelvin, Celsius");
                string fah = Console.ReadLine();

                    if (fah == "Kelvin")
                    {
                        Console.WriteLine("Enter amount to convert: ");
                        double fahren = Convert.ToDouble(Console.ReadLine());
                        double conv = (fahren - 32) * 5/9 + 273.15;
                        Console.WriteLine(conv);
                    }
                    else if (fah == "Celsius")
                    {
                        Console.WriteLine("Enter amount to convert: ");
                        double fahren = Convert.ToDouble(Console.ReadLine());
                        double conv = (fahren - 32) * 5/9;
                        Console.WriteLine(conv);
                    }
                    else 
                    {
                        Console.WriteLine("Error try again: did you misspell a word?");
                    }
            }
        else if (temperature == "Kelvin")
            {   // Kelvin > Celsius formula == n°K − 273.15 = -x°C
                // Kelvin > Fahrenheit formula == (n°K − 273.15) × 9/5 + 32 = -x°F
                Console.WriteLine("Convert Kelvin into: Celsius, Fahrenheit");
                string kev = Console.ReadLine();

                    if (kev == "Fahrenheit")
                    {
                        Console.WriteLine("Enter amount to convert: ");
                        double kelvi = Convert.ToDouble(Console.ReadLine());
                        double conv = (kelvi - 273.15) * 9/5;
                        Console.WriteLine(conv);
                    }
                    else if (kev == "Celsius")
                    {
                        Console.WriteLine("Enter amount to convert: ");
                        double kelvi = Convert.ToDouble(Console.ReadLine());
                        double conv = kelvi - 273.15;
                        Console.WriteLine(conv);
                    }
            }
        else
            {
                Console.WriteLine("Error try again, did you misspell a word?");
            }
        }

    }
}