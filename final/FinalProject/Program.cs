// ABANDONED:
// "Not clear how this will get you 200 points. This looks like you will only get about maybe 125 points on the assignment?"
// " I hope you consider either making this more complex or doing the Foundation 4. Foundation 4 has many more things going on in it than this and is more complex (also more well defined)."

// Tutorials about files: learned from https://www.delftstack.com/es/howto/csharp/delete-files-from-a-directory-in-csharp/
// also https://learn.microsoft.com/es-es/dotnet/api/system.io.file.create?view=net-7.0

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        // IMPORTANT: When typing the user name, don't use the file extension, such as "John.txt" or "John.csv".
        // Just type the name: "John".

        Console.Clear();
        Console.WriteLine("WELCOME TO THE 'MOOD ENHANCER' PROGRAM!\n");
        Console.WriteLine(">This program is intended to help the user to lift their spirits and remind them of positive activities that they can do when they're sad or unmotivated\n");

        int option = 0;
        User user = new User();

        List<string> initialMenu = new List<string>()
        {
            "New user",
            "Load user",
            "Remove user",
            "Quit"
        };

        while (option != initialMenu.Count())
        {
            option = DisplayMenu(initialMenu);

            switch (option)
            {
                case 1:
                    // New user
                    NewUser(user);
                    break;
                
                case 2:
                    // Load user
                    LoadUser(user);
                    break;
                
                case 3:
                    // Remove user
                    RemoveUser(user);
                    break;
                
                default:
                    Console.WriteLine("Select a valid option");
                    break;
            }
        }
    }
    public static int DisplayMenu(List<string> list)
    {
        DisplayList(list);

        Console.Write("\nChoose an option: ");

        return int.Parse(Console.ReadLine());
    }
    public static void DisplayList(List<string> list)
    {
        for (int i = 1; i <= list.Count() ; i++)
        {
            Console.WriteLine($"  > {i}. {list[i - 1]}");
        }
    }

    static void NewUser(User user)
    {
        string userName = CreateFolder();
        string password = GetUserPassword();
        user.SetUserName(userName);
        user.SetPassword(password);

        MenuContainer userMenu = new MenuContainer();
        user = userMenu.UserMenu(user);

        // Save user info.
        SaveUserInfo(user, userName);
    }
    static void LoadUser(User user)
    {
        user.ResetUserInfo();
        string userName = GetUserName();
        string folderPath = GetFolderPath(userName);

        ValidateUser(user, userName, out userName, out folderPath);

        // Loading file data code <-- completar!!

        MenuContainer userMenu = new MenuContainer();
        user = userMenu.UserMenu(user);

        // Save user info.
        SaveUserInfo(user, userName);
    }
    static void SaveUserInfo(User user, string userName)
    {
        using (FileStream outputFile = File.Create(GetFolderPath(userName) + $"\\{userName}.txt"))
        {
            List<string> list = new List<string>()
            {
                userName,
                "Asdasdasd",
                $"asdas {userName}{user.GetPassword()}"
            };
            foreach (string data in list)
            {
                byte[] info = new UTF8Encoding(true).GetBytes(data);
                outputFile.Write(info, 0, info.Length);
            }
            
            //complete here!!!
        }
    }
    static void ValidateUser(User user, string userName, out string correctUserName, out string folderPath)
    {
        folderPath = GetFolderPath(userName);

        while (!Directory.Exists(folderPath) || userName == "")
        {
            Console.WriteLine("\nDoesn't exists a user with that name.\n");
            userName = GetUserName();
            folderPath = GetFolderPath(userName);
        }
        correctUserName = userName;

        string password = GetUserPassword();
        while (!user.VerifyPassword(password))
        {
            Console.WriteLine("Invalid password. Try again");
            password = GetUserPassword();
        }
    }
    static void RemoveUser(User user)
    {
        string userName = GetUserName();
        string folderPath;

        ValidateUser(user, userName, out userName, out folderPath);

        DirectoryInfo dI = new DirectoryInfo(folderPath);

        FileInfo[] files = dI.GetFiles();
        foreach (FileInfo file in files)
        {
            file.Delete();
        }
        dI.Delete(true);

        WriteText(120,"Files deleted successfully...", 800); 
    }
    static void WriteText(int speed, string text, int finalSleep = 0)
    {
        foreach (char i in text)
        {
            Console.Write(i);
            Thread.Sleep(speed);
        }
        Console.WriteLine();
        Thread.Sleep(finalSleep);
    }
    static string GetFolderPath(string userName)
    {
        return Environment.CurrentDirectory + "\\" + userName;
    }
    static string GetUserName()
    {
        Console.Write("What is the name of the user? (don't use file extensions like '.txt') ");
        return Console.ReadLine();
    }
    static string GetUserPassword()
    {
        Console.Write("Password: ");
        return Console.ReadLine();
    }
    static string CreateFolder()
    {
        string userName = GetUserName();
        string folderPath = GetFolderPath(userName);

        while (Directory.Exists(folderPath))
        {
            Console.WriteLine("\nA user already exists with that name. Delete it or choose another name.\n");
            userName = GetUserName();
            folderPath = GetFolderPath(userName);
        }

        Directory.CreateDirectory(folderPath);

        return userName;
    }
}