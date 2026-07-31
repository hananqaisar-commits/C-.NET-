

using System.Runtime.InteropServices;

namespace Extensions.ValidAction;

public static class ValidAction
{
    public static bool IsValidSongInput(this string songName)
    {
        if (!(string.IsNullOrEmpty(songName) && string.IsNullOrWhiteSpace(songName)))
            return true;
        else
            return false;
    }
}