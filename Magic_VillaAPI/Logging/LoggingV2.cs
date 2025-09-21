namespace Magic_VillaAPI.Logging
{
    public class LoggingV2 : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "Error")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error V2 : {message}");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                if (type == "warning")
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Error :   {message} ");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.WriteLine($"Info V2 : {message}");
                }
            }
        }
    }
}
