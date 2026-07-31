namespace Extensions.ValidAction;

public static class ValidAction
{
    public static bool IsValidSongInput(this string songName)
    {
        return !string.IsNullOrWhiteSpace(songName);
    }
}