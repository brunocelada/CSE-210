using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Console.Clear();

        List<Event> events = new List<Event>();

        Address address1 = new Address("Ituzaingo 6462", "Rosario", "Santa Fe", "Argentina");
        Address address2 = new Address("Ituzaingo 6000", "Clearfield", "Utah", "USA");
        Address address3 = new Address("Iriondo 1327", "Rosario", "Santa Fe", "Argentina");

        Lectures lectureEvent = new Lectures("Marcelo's Birthday", "Marcelo lectures in his house", "Monday 13/6/24", "3pm", address1, "Michael", 8);
        Receptions receptionEvent = new Receptions("Jorge's Wedding", "Jorge is getting merried with Lorena", "Tuesday 23/2/23", "5pm", address2, "michael@gmail.com");
        OutdoorGatherings outdoorEvent = new OutdoorGatherings("Micaela's Baptism", "Micaela is getting baptized in the LDS Church", "Saturday 17/8/23", "7pm", address3, "Sunny, 23°C, 70% Humidity");

        events.Add(lectureEvent);
        events.Add(receptionEvent);
        events.Add(outdoorEvent);

        Console.Clear();

        foreach (Event cEvent in events)
        {
            Console.WriteLine($"{cEvent.DisplayStandardDetails()}\n");
            Console.WriteLine($"{cEvent.DisplayFullDetails()}\n");
            Console.WriteLine($"{cEvent.DisplayShortDescription()}\n");
            Console.WriteLine();
        }
    }
}