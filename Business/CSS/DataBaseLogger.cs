using System;

namespace Business.CSS
{
    public class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına Loglandı");
        }
    }
}
