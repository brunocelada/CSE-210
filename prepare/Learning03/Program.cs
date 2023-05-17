using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
    
        Console.WriteLine("1. Initializate with no parameters (1/1)");
        Console.WriteLine("2. Initializate with whole number (bottom = 1)");
        Console.WriteLine("3. Initializate whit both parameters");
        Console.WriteLine("4. Set the parameters");
        Console.WriteLine("5. Quit");
        Console.WriteLine();

        Console.Write("Select an option: ");
        int userOption = int.Parse(Console.ReadLine());
        bool option = true;
        int topGetted;
        int bottomGetted;
        string fractionString;
        double decimalValue;
        int top;
        int bottom;

        Fraction fraction;

        while (option){
            switch (userOption){
                case 1:
                    // Initializate with no parameters (1/1).
                    fraction = new Fraction();

                    // Display.
                    topGetted = fraction.GetTop();
                    bottomGetted = fraction.GetBottom();
                    Console.WriteLine($"GetTop: {topGetted} - GetBottom: {bottomGetted}");
                    fractionString = fraction.GetFractionString();
                    decimalValue = fraction.GetDecimalValue();
                    Console.WriteLine($"GetFractionString: {fractionString} - GetDecimalValue: {decimalValue}");

                    Console.Write("Select another option: ");
                    userOption = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    // Initializate with whole number (bottom = 1).
                    Console.Write("The top number: ");
                    top = int.Parse(Console.ReadLine());
                    fraction = new Fraction(top);

                    // Display.
                    topGetted = fraction.GetTop();
                    bottomGetted = fraction.GetBottom();
                    Console.WriteLine($"GetTop: {topGetted} - GetBottom: {bottomGetted}");
                    fractionString = fraction.GetFractionString();
                    decimalValue = fraction.GetDecimalValue();
                    Console.WriteLine($"GetFractionString: {fractionString} - GetDecimalValue: {decimalValue}");

                    Console.Write("Select another option: ");
                    userOption = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    // Initializate whit both parameters.
                    Console.Write("The top number: ");
                    top = int.Parse(Console.ReadLine());
                    Console.Write("The bottom number: ");
                    bottom = int.Parse(Console.ReadLine());
                    fraction = new Fraction(top, bottom);

                    // Display.
                    topGetted = fraction.GetTop();
                    bottomGetted = fraction.GetBottom();
                    Console.WriteLine($"GetTop: {topGetted} - GetBottom: {bottomGetted}");
                    fractionString = fraction.GetFractionString();
                    decimalValue = fraction.GetDecimalValue();
                    Console.WriteLine($"GetFractionString: {fractionString} - GetDecimalValue: {decimalValue}");

                    Console.Write("Select another option: ");
                    userOption = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    // Set the parameters.
                    Console.Write("The top number: ");
                    top = int.Parse(Console.ReadLine());
                    Console.Write("The bottom number: ");
                    bottom = int.Parse(Console.ReadLine());
                    fraction = new Fraction();
                    fraction.SetBottom(bottom);
                    fraction.SetTop(top);

                    // Display.
                    topGetted = fraction.GetTop();
                    bottomGetted = fraction.GetBottom();
                    Console.WriteLine($"GetTop: {topGetted} - GetBottom: {bottomGetted}");
                    fractionString = fraction.GetFractionString();
                    decimalValue = fraction.GetDecimalValue();
                    Console.WriteLine($"GetFractionString: {fractionString} - GetDecimalValue: {decimalValue}");
                    Console.Write("Select another option: ");
                    userOption = int.Parse(Console.ReadLine());

                    break;
                case 5:
                    // Close.
                    option = false;
                    break;

                default:
                    Console.Write("Select a valid number: ");
                    userOption = int.Parse(Console.ReadLine());
                    break;
            }
            Console.WriteLine();
        }
        
    }
}