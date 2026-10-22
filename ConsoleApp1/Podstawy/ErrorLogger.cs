using System;

namespace ConsoleApp1.Podstawy
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public void LogError(string message)
        {
            //jeżeli log będzie pusty to wywołujemy wyjątek
            // null, "", "   " - wszystkie te przypadki są traktowane jako puste
            if (String.IsNullOrWhiteSpace(message))
                throw new ArgumentNullException("Error message cannot be null or empty.");
            

            LastError = message;
            // Log the error to a file or database
        }
    }
}
