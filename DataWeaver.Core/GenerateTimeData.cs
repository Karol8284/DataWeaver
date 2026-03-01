using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DataWeaver.Core
{
    public class GenerateTimeData
    {
        public DateTime ReturnCurrentDateTime()
        {
            return DateTime.Now;
        }
        public DateTime ReturnCurrentDateDay()
        {
            return DateTime.Today;
        }
        public int ReturnCurrentDay()
        {
            return DateTime.Now.Day;
        }
        public int ReturnRandomDay()
        {
            Random random = new Random();
            return random.Next(1, 31);
        }
        public int ReturnRandomDay(int start, int end)
        {
            return RandomNumberGenerator.GetInt32(start, end);
        }

    }
}
