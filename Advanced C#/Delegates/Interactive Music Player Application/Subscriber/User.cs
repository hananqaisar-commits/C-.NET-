using System;
using Player.MusicPlayer;
namespace Subscriber.User;

public class User
{
    public string Name { get; set; } = "";
    public User(string Name)
    {
        this.Name = Name;
    }
    public void OnSongPlayed(string SongTitle)
    {
        Console.WriteLine($"{Name} is Playing song {SongTitle}");
    }

    public void OnSongPaused(string SongTitle)
    {
        Console.WriteLine($"{Name} paused song {SongTitle}");
    }

    public void OnSongSkipped(string SongTitle)
    {
        Console.WriteLine($"{Name} skipped song {SongTitle}");
    }

    public void OnSongStopped(string SongTitle)
    {
        Console.WriteLine($"{Name} stopped song {SongTitle}");
    }
}