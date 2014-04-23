using System;

namespace Eloquent
{
    /*
     * Eloquent Expressions
     * 
     * 10.Minutes.Ago
     * 10.Years
     * 10.Times(x=>x...)
     * DateTime dt = 10.Days.FromNow
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    public static class TimeSpanExtensions
    {
        public static TimeSpan Milliseconds(this int value)
        {
            return new TimeSpan(0, 0, 0, 0, value);
        }

        public static TimeSpan Seconds(this int value)
        {
            return new TimeSpan(0, 0, 0, value);
        }

        public static TimeSpan Minutes(this int value)
        {
            return new TimeSpan(0, 0, value, 0);
        }

        public static TimeSpan Hours(this int value)
        {
            return new TimeSpan(0, value, 0, 0);
        }

        public static TimeSpan Days(this int value)
        {
            return new TimeSpan(value, 0, 0, 0);
        }
    
        public static DateTime Ago(this TimeSpan value)
        {
            return DateTime.Now.Subtract(value);
        }

        public static DateTime FromNow(this TimeSpan value)
        {
            return DateTime.Now.Add(value);
        }
    }
}
