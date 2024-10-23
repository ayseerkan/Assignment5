namespace BLL.Services.Bases;

public class Service
{
    // Common properties or methods for all services
    public string ServiceName { get; set; }

    public void Log(string message)
    {
        // Generic logging functionality
        Console.WriteLine($"Log from Service: {message}");
    }

    // Other common methods could go here...
}
}