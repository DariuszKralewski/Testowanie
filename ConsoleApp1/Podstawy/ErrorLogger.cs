namespace ConsoleApp1.Podstawy
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public void LogError(string message)
        {
            LastError = message;
            // Log the error to a file or database
        }
    }
}
