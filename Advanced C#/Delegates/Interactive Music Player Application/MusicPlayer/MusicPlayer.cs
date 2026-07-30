using System;
using System.Runtime.CompilerServices;

namespace Player.MusicPlayer;

public delegate void EventHandler(string songName);//custom delegate
public class MusicPlayer
{
    public event EventHandler playEvent;
    public event EventHandler pauseEvent;
    public event EventHandler stopEvent;
    public event EventHandler skipEvent;
    public void Play(string songName)
    {
        Console.WriteLine($"Song Played {songName}");
        playEvent?.Invoke(songName);
    }
    public void Pause(string songName)
    {
        Console.WriteLine($"Song Paused {songName}");
        pauseEvent?.Invoke(songName);
    }
    public void Stop(string songName)
    {
        Console.WriteLine($"Song Stoped {songName}");
        stopEvent?.Invoke(songName);
    }

    public void Skipped(string songName)
    {
        Console.WriteLine($"Song Skipped {songName}");
        skipEvent?.Invoke(songName);
    }
}