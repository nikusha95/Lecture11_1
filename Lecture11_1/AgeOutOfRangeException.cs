namespace Lecture11_1;

public class AgeOutOfRangeException : Exception
{
    private readonly string? _details;
    public string? Details  => _details;
    public AgeOutOfRangeException(string message, string? details) : base(message)
    {
        _details = details;
    }

    public AgeOutOfRangeException(string message, Exception innerException )
        :base(message,innerException)
    {
        
    }
}