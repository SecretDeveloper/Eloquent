using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Eloquent
{
    public static class StringExtensions
    {

        #region Convert

        public static Boolean ToBoolean(this string value)
        {
            return Convert.ToBoolean(value);
        }

        public static Byte ToByte(this string value)
        {
            return Convert.ToByte(value);
        }

        public static DateTime ToDateTime(this string value)
        {
            return Convert.ToDateTime(value);
        }

        public static Decimal ToDecimal(this string value)
        {
            return Convert.ToDecimal(value);
        }

        public static Double ToDouble(this string value)
        {
            return Convert.ToDouble(value);
        }
        
        public static Int32 ToInt16(this string value)
        {
            return Convert.ToInt16(value);
        }

        public static Int32 ToInt32(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static Int64 ToInt64(this string value)
        {
            return Convert.ToInt64(value);
        }

        public static SByte ToSByte(this string value)
        {
            return Convert.ToSByte(value);
        }

        public static Single ToSingle(this string value)
        {
            return Convert.ToSingle(value);
        }

        public static UInt16 ToUInt16(this string value)
        {
            return Convert.ToUInt16(value);
        }

        public static UInt32 ToUInt32(this string value)
        {
            return Convert.ToUInt32(value);
        }

        public static UInt64 ToUInt64(this string value)
        {
            return Convert.ToUInt64(value);
        }

        #endregion

        #region Parsing

        public static DateTime ParseDateTime(this string value)
        {
            return DateTime.Parse(value);
        }

        public static DateTime ParseDateTime(this string value, IFormatProvider provider)
        {
            return DateTime.Parse(value, provider);
        }

        public static DateTime ParseDateTime(this string value, IFormatProvider provider, DateTimeStyles styles)
        {
            return DateTime.Parse(value, provider, styles);
        }

        public static bool TryParseDateTime(this string value, out DateTime result)
        {
            return DateTime.TryParse(value, out result);
        }
        
        public static bool TryParseDateTime(this string value, out DateTime result, IFormatProvider provider, DateTimeStyles styles)
        {
            return DateTime.TryParse(value, provider, styles, out result);
        }

        public static Int16 ParseInt16(this string value)
        {
            return Int16.Parse(value);
        }

        public static bool TryParseInt16(this string value, out Int16 result)
        {
            return Int16.TryParse(value, out result);
        }

        public static Int32 ParseInt32(this string value)
        {
            return Int32.Parse(value);
        }

        public static bool TryParseInt32(this string value, out Int32 result)
        {
            return Int32.TryParse(value, out result);
        }

        public static Int64 ParseInt64(this string value)
        {
            return Int64.Parse(value);
        }

        public static bool TryParseInt64(this string value, out Int64 result)
        {
            return Int64.TryParse(value, out result);
        }

        #endregion

        #region Queries

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        #endregion

        #region Functions

        public static string Format(this string value, params object[] args)
        {
            return string.Format(value, args);
        }

        /// <summary>
        /// Calls string.Join and uses the current string as the separator value.
        /// </summary>
        /// <remarks>
        /// var csv = ','.Join(array);
        /// </remarks>
        /// <param name="value"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string Join(this string value, params object[] args)
        {
            return string.Join(value, args);
        }

        public static MatchCollection RegexMatches(this string value, string pattern)
        {
            return Regex.Matches(value, pattern);
        }

        public static string RegexReplace(this string value, string pattern, string replacement)
        {
            var regex = new Regex(pattern);
            return regex.Replace(value, replacement);
        }

        #endregion

    }
}