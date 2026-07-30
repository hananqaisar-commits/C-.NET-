using System;
using Subscriber.User;
using Player.MusicPlayer;
using System.Threading.Tasks;

namespace Interactive_Music_Player_Application;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("===========================================");
        Console.WriteLine("       Interactive Music Player  ");
        Console.WriteLine("===========================================\n");

        MusicPlayer musicPlayer = new MusicPlayer();

        Action();
        User hanan = new User("Hanan");
        User ali = new User("Ali");
        User hamza = new User("Hamza");
        User ahmad = new User("Ahmad");

        Console.WriteLine("Creating Subscribers...");
        Console.WriteLine(" Hanan");
        Console.WriteLine(" Ali");
        Console.WriteLine(" Hamza");
        Console.WriteLine(" Ahmad\n");
        Action();

        Console.WriteLine("Subscribing users to Play Event...");
        musicPlayer.playEvent += hanan.OnSongPlayed;//mean put refernce of method OnSongPlayed of user hanan into the musiclibrary playevent of delagate(EventHandler)
        musicPlayer.playEvent += ali.OnSongPlayed;
        musicPlayer.playEvent += ahmad.OnSongPlayed;
        musicPlayer.playEvent += hamza.OnSongPlayed;

        Console.WriteLine(" Ahmad Subscribed");
        Action();
        Console.WriteLine("\nAll subscribers are ready!\n\n Start Music Player");

        while (true)
        {
            Console.WriteLine("-------------------------------------------");
            Console.Write("Action (play, pause, skip, stop, exit): ");

            string? action = Console.ReadLine()?.ToLower();

            if (action == "exit")
            {
                Console.WriteLine("\nClosing Music Player...");
                break;
            }

            Console.Write("Song Name: ");
            string? songName = Console.ReadLine();

            if (string.IsNullOrEmpty(songName))
            {
                Console.WriteLine("Song name cannot be empty!");
                Action();
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("       Interactive Music Player  ");
                Console.WriteLine("===========================================\n");
                continue;
            }

            Console.WriteLine();

            switch (action)
            {
                case "play":
                    Console.WriteLine($" Playing '{songName}'...");
                    musicPlayer.Play(songName);
                    break;

                case "pause":
                    Console.WriteLine($" Pausing '{songName}'...");
                    musicPlayer.Pause(songName);
                    break;

                case "skip":
                    Console.WriteLine($" Skipping '{songName}'...");
                    musicPlayer.Skipped(songName);
                    break;

                case "stop":
                    Console.WriteLine($" Stopping '{songName}'...");
                    musicPlayer.Stop(songName);
                    break;

                default:
                    Console.WriteLine("Invalid Action!");
                    break;
            }

            Action();

            Console.WriteLine("===========================================");
            Console.WriteLine("       Interactive Music Player  ");
            Console.WriteLine("===========================================\n");
        }
    }
    static void Action()
    {
        Task.Delay(1000);
        Console.WriteLine("\nPress any key to continue...\n");
        Console.ReadKey();
    }
}