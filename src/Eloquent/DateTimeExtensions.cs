using System;

namespace Eloquent
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns a DateTime with its value set to Now minus the provided TimeSpan value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime Ago(this TimeSpan value)
        {
            return DateTime.Now.Subtract(value);
        }

        /// <summary>
        /// Returns a DateTime with its value set to Now plus the provided TimeSpan value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime FromNow(this TimeSpan value)
        {
            return DateTime.Now.Add(value);
        }

        /// <summary>
        /// Returns a DateTime with its value set to Now minus the provided TimeSpan value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime AgoUtc(this TimeSpan value)
        {
            return DateTime.UtcNow.Subtract(value);
        }

        /// <summary>
        /// Returns a DateTime with its value set to Now plus the provided TimeSpan value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime FromNowUtc(this TimeSpan value)
        {
            return DateTime.UtcNow.Add(value);
        }
    }
}