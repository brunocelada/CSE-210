using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        /* 
            A >= 90
            B >= 80
            C >= 70
            D >= 60
            F < 60
        */

        // Ask the user the grade percentage.
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        // Determine the letter grade.
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign grade.
        string sign = "";
        if (grade % 10 >= 7)
        {
            if (letter == "A")
            {
                sign = "";
            }
            else
            {
                sign = "+";
            }
        }
        else if (grade % 10 < 3)
        {
            sign = "-";
        }
        if (letter == "F")
        {
            sign = "";
        }

        // Print the letter grade.
        Console.WriteLine($"Your letter grade is {letter}{sign}");

        // Determine if the user passed the course.
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course! Keep growing");
        }
        else
        {
            Console.WriteLine("Don't give up, keep trying!");
        }
    }
}