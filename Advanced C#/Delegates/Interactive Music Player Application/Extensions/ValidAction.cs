namespace Extensions.ValidAction;

public static class ValidAction
{
    [Obsolete("Use only for Song input validation")]
    public static bool IsValidSongInput(this string songName) =>
        !string.IsNullOrWhiteSpace(songName);

    public static bool IsValidMusicPlayerAction(this string musicPlayerAction) =>

        string.IsNullOrWhiteSpace(musicPlayerAction);


}