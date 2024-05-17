using System;


namespace CSharpJourney{

    class CustomException: Exception{
        public CustomException(string message, Exception innerException): base(message, innerException)
        {
            Console.WriteLine("This is a custom exception 🤫");
        }
    }
}