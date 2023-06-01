using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment multip = new Assignment("Bruno", "Chemistry");
        Console.WriteLine (multip.GetSummary());
        Console.WriteLine();

        MathAssignment math1 = new MathAssignment("Doris", "Maths", "5.3", "10-13,14");
        Console.WriteLine (math1.GetSummary());
        Console.WriteLine (math1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment("Javier", "Music", "Get the job done");
        Console.WriteLine (writing1.GetSummary());
        Console.WriteLine (writing1.GetWritingInformation());
        Console.WriteLine();
    }
}