using System;
using System.Runtime.CompilerServices;

namespace Player.MusicPlayer;

public class MusicPlayer
{
    public event Action<string> playEvent;
    public event Action<string> pauseEvent;
    public event Action<string> stopEvent;
    public event Action<string> skipEvent;
    public void Play(string songName) => playEvent?.Invoke(songName);

    public void Pause(string songName) => pauseEvent?.Invoke(songName);

    public void Stop(string songName) => stopEvent?.Invoke(songName);


    public void Skipped(string songName) => skipEvent?.Invoke(songName);
}
