using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSOLID
{
    public interface ILogger
    {
        void LogError(Exception ex);
    }

    public class FileLogger : ILogger
    {
        public void LogError(Exception ex)
        {
            Console.WriteLine("Log into physycal file"  + ex.Message.ToString());
        }
    }

    public class EventViewLogger : ILogger
    {
        public void LogError(Exception ex)
        {
            Console.WriteLine("Log into Event View "+ ex.Message.ToString());
        }
    }



}
