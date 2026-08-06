public class FileLogger : IDisposable
{
    public string? _filepath;
    public StreamWriter? _writer;
    public FileLogger(string _filepath)
    {
        _writer = new StreamWriter(_filepath, append: true);
    }
    public void Log(string message)
    {
        _writer?.WriteLine($"  File written on :{DateTime.Now} ➡️ {message}");
        _writer?.Flush();
    }
    public void Dispose()
    {
        _writer?.Dispose();
        Console.WriteLine("StreamWriter is disposed now");
        _writer = null;// making sure it will not used again
    }

}