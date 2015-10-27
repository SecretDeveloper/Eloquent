using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace Eloquent
{
    public static class StringExtensions
    {

        #region Convert

        public static Boolean ToBoolean(this string value)
        {
            return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
        }

        public static Byte ToByte(this string value)
        {
            return Convert.ToByte(value, CultureInfo.InvariantCulture);
        }

        public static DateTime ToDateTime(this string value)
        {
            return Convert.ToDateTime(value, CultureInfo.InvariantCulture);
        }

        public static Decimal ToDecimal(this string value)
        {
            return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
        }

        public static Double ToDouble(this string value)
        {
            return Convert.ToDouble(value, CultureInfo.InvariantCulture);
        }
        
        public static Int32 ToInt16(this string value)
        {
            return Convert.ToInt16(value, CultureInfo.InvariantCulture);
        }

        public static Int32 ToInt32(this string value)
        {
            return Convert.ToInt32(value, CultureInfo.InvariantCulture);
        }

        public static Int64 ToInt64(this string value)
        {
            return Convert.ToInt64(value, CultureInfo.InvariantCulture);
        }

        public static SByte ToSByte(this string value)
        {
            return Convert.ToSByte(value, CultureInfo.InvariantCulture);
        }

        public static Single ToSingle(this string value)
        {
            return Convert.ToSingle(value, CultureInfo.InvariantCulture);
        }

        public static UInt16 ToUInt16(this string value)
        {
            return Convert.ToUInt16(value, CultureInfo.InvariantCulture);
        }

        public static UInt32 ToUInt32(this string value)
        {
            return Convert.ToUInt32(value, CultureInfo.InvariantCulture);
        }

        public static UInt64 ToUInt64(this string value)
        {
            return Convert.ToUInt64(value, CultureInfo.InvariantCulture);
        }

        #endregion

        #region Parsing

        public static DateTime ParseDateTime(this string value)
        {
            return DateTime.Parse(value, CultureInfo.InvariantCulture);
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
            return DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out result);
        }

        public static bool TryParseDateTime(this string value, out DateTime result, IFormatProvider provider)
        {
            return DateTime.TryParse(value, provider, DateTimeStyles.AssumeLocal, out result);
        }

        public static bool TryParseDateTime(this string value, out DateTime result, IFormatProvider provider, DateTimeStyles styles)
        {
            return DateTime.TryParse(value, provider, styles, out result);
        }

        public static Int16 ParseInt16(this string value)
        {
            return Int16.Parse(value, CultureInfo.InvariantCulture);
        }

        public static bool TryParseInt16(this string value, out Int16 result)
        {
            return Int16.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
        }

        public static Int32 ParseInt32(this string value)
        {
            return Int32.Parse(value, NumberStyles.Any, CultureInfo.InvariantCulture);
        }

        public static bool TryParseInt32(this string value, out Int32 result)
        {
            return Int32.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
        }

        public static Int64 ParseInt64(this string value)
        {
            return Int64.Parse(value, NumberStyles.Any, CultureInfo.InvariantCulture);
        }

        public static bool TryParseInt64(this string value, out Int64 result)
        {
            return Int64.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
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

        /// <summary>
        /// Returns a measure of the information content of a string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Entropy(this string value)
        {
            var dict = CountDistinctCharacters(value);

            double infoCount=0d;
            double logTwo = Math.Log(2);

            foreach (var kv in dict)
            {
                double freq = kv.Value/value.Length;
                infoCount += freq*Math.Log(freq)/logTwo;
            }
            infoCount *= -1;
            return infoCount;
        }

        private static Dictionary<char, double> CountDistinctCharacters(string value)
        {
            var dict = new Dictionary<char, double>();

            foreach (var c in value)
            {
                if (!dict.ContainsKey(c))
                    dict[c] = 1;
                else
                    dict[c] = dict[c] + 1;
            }
            return dict;
        }

        #endregion

        #region Functions

        public static string Format(this string value, params object[] args)
        {
            return string.Format(CultureInfo.InvariantCulture, value, args);
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
            return string.Join(value, args, CultureInfo.InvariantCulture);
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

        /// <summary>
        /// Returns an escaped string where whitespace characters are replaced with their non-whitespace symbol.
        ///     HorizontalTab:  \t
        ///     VerticalTab:    \v
        ///     NewLine:        \n
        ///     CarriageReturn: \r
        ///     FormFeed:       \f
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToLiteral(this string value)
        {
            using (var writer = new StringWriter(CultureInfo.InvariantCulture))
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    var opts = new CodeGeneratorOptions();
                    opts.VerbatimOrder = true;
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(value), writer, opts);
                    return writer.ToString();
                }
            }
        }

        #endregion

    }
}