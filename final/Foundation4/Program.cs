using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        // I use the next example but I think it's incorrect, because to calculate the
        // speed = distance(km) / time (min) * 60 (to convert in km/h). And with the values of
        // 30 min for time and 4.8 km for distance, the speed = 9.6 km/h and the pace 6.25 min per km.
            // Example shared in the preparation material:
            // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km

        // Notice also that mi program use "," instead of "." for the decimal division. 
        // That can be different in other system's languages.

        List<Activity> activities = new List<Activity>();

        Running running = new Running("15 Feb 2023", float.Parse("30"), float.Parse("4,8"));
        Swimming swimming = new Swimming("15 Feb 2023", float.Parse("24,3"), float.Parse("22"));
        StationaryBicycles stationaryBicycles = new StationaryBicycles("15 Feb 2023", float.Parse("24,3"), float.Parse("5.7"));

        activities.Add(running);
        activities.Add(swimming);
        activities.Add(stationaryBicycles);

        Console.Clear();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}