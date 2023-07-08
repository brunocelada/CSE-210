using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Console.Clear();
        Console.WriteLine("YOUTUBE VIDEOS\n");

        List<Video> videosList = new List<Video>();

        // I know it's not necessary to add a user interface but I added them in the programs for practice.
        
        Console.Write("How many videos are you going to add? ");
        int numberOfVideos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfVideos; i++)
        {
            Console.WriteLine("\nVIDEO INFO\n");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Lenght (in seconds): ");
            int lenght = int.Parse(Console.ReadLine());

            Video video = new Video(title, author, lenght);
            
            Console.WriteLine("\nCOMMENTS\n");
            Console.Write("How many comments are in the video? ");
            int numberOfComments = int.Parse(Console.ReadLine());

            for (int j = 1; j <= numberOfComments; j++)
            {
                Console.Write("Name (user): ");
                string name = Console.ReadLine();
                Console.Write("Comment: ");
                string commentText = Console.ReadLine();

                video.AddComment(name, commentText);
            }

            videosList.Add(video);
        }

        Console.Clear();
        Console.WriteLine("\n\nVideos list:\n");
        foreach (Video video in videosList)
        {
            video.DisplayVideo();
        }
    }
}