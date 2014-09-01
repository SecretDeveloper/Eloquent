using System;

namespace Eloquent
{
    public static class IntExtensions
    {
        private const Int64 KILOBYTE = 1024;
        private const Int64 MEGABYTE = KILOBYTE * 1024;
        private const Int64 GIGABYTE = MEGABYTE * 1024;
        private const Int64 TERABYTE = GIGABYTE * 1024;
        private const Int64 PETABYTE = TERABYTE * 1024;
        private const Int64 EXABYTE =  PETABYTE * 1024;

        public static Int64 Bytes(this int number)
        {
            return number;
        }

        public static Int64 Kilobytes(this int number)
        {
            return number * KILOBYTE;
        }

        public static Int64 Megabytes(this int number)
        {
            return number * MEGABYTE;
        }

        public static Int64 Gigabytes(this int number)
        {
            return number * GIGABYTE;
        }

        public static Int64 Terabytes(this int number)
        {
            return number * TERABYTE;
        }

        public static Int64 Petabytes(this int number)
        {
            return number * PETABYTE;
        }

        public static Int64 Exabytes(this int number)
        {
            return number * EXABYTE;
        }

        public static void Times(this int times, Action action)
        {
            for (int i = 0; i < times; i++)
            {
                action();
            }
        }
    }
}