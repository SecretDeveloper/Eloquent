using System;

namespace Eloquent
{
    /// <summary>
    /// TimeSpan related eloquent expressions.
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Returns a TimeSpan with its Milliseconds property set to the value of the int.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TimeSpan Milliseconds(this int value)
        {
            return new TimeSpan(0, 0, 0, 0, value);
        }

        /// <summary>
        /// Returns a TimeSpan with its Seconds property set to the value of the int.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TimeSpan Seconds(this int value)
        {
            return new TimeSpan(0, 0, 0, value, 0);
        }

        /// <summary>
        /// Returns a TimeSpan with its Minutes property set to the value of the int.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TimeSpan Minutes(this int value)
        {
            return new TimeSpan(0, 0, value, 0, 0);
        }

        /// <summary>
        /// Returns a TimeSpan with its Hours property set to the value of the int.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TimeSpan Hours(this int value)
        {
            return new TimeSpan(0, value, 0, 0, 0);
        }

        /// <summary>
        /// Returns a TimeSpan with its Days property set to the value of the int.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TimeSpan Days(this int value)
        {
            return new TimeSpan(value, 0, 0, 0);
        }
    }
}
