using System;
using System.Globalization;

namespace Eloquent
{
    public static class ObjectExtensions
    {
        #region Convert

        public static Boolean ToBoolean(this object value)
        {
            return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
        }

        public static Byte ToByte(this object value)
        {
            return Convert.ToByte(value, CultureInfo.InvariantCulture);
        }

        public static DateTime ToDateTime(this object value)
        {
            return Convert.ToDateTime(value, CultureInfo.InvariantCulture);
        }

        public static Decimal ToDecimal(this object value)
        {
            return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
        }

        public static Double ToDouble(this object value)
        {
            return Convert.ToDouble(value, CultureInfo.InvariantCulture);
        }

        public static Int32 ToInt16(this object value)
        {
            return Convert.ToInt16(value, CultureInfo.InvariantCulture);
        }

        public static Int32 ToInt32(this object value)
        {
            return Convert.ToInt32(value, CultureInfo.InvariantCulture);
        }

        public static Int64 ToInt64(this object value)
        {
            return Convert.ToInt64(value, CultureInfo.InvariantCulture);
        }

        public static SByte ToSByte(this object value)
        {
            return Convert.ToSByte(value, CultureInfo.InvariantCulture);
        }

        public static Single ToSingle(this object value)
        {
            return Convert.ToSingle(value, CultureInfo.InvariantCulture);
        }

        public static UInt16 ToUInt16(this object value)
        {
            return Convert.ToUInt16(value, CultureInfo.InvariantCulture);
        }

        public static UInt32 ToUInt32(this object value)
        {
            return Convert.ToUInt32(value, CultureInfo.InvariantCulture);
        }

        public static UInt64 ToUInt64(this object value)
        {
            return Convert.ToUInt64(value, CultureInfo.InvariantCulture);
        }

        #endregion
    }
}
