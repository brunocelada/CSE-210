using System;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Set the initial variables
        int newNumber;
        List<int> listNumbers = new List<int>();
        int total = 0;
        int largest = -99999;
        int smallestPositive = 9999999;

        // Ask the user for a new number until he/she
        // enters 0, and add the number to the end of 
        // the list.
        do{
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());

            listNumbers.Add(newNumber);
        } while (newNumber != 0);

        // Loop to compute values.
        foreach (int number in listNumbers)
        {
            // Compute the total sum.
            total += number;
            
            // Compute the largest number.
            if (number > largest)
            {
                largest = number;
            }
            // Compute the smallest positive number.
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        // Compute the average and round it into 2 decimal places.
        float average = (float) total / (listNumbers.Count - 1);
        float averageRound = MathF.Round(average, 2);

        // Print the results.
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {averageRound}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort and print the list in ascending order.
        listNumbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in listNumbers)
        {
            Console.WriteLine(number);
        }
    }
}