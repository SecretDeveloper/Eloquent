using System;

namespace Eloquent
{
    public static class IntExtensions
    {
        public static void Times(this int times, Action action)
        {
            for (int i = 0; i < times; i++)
            {
                action();
            }
        }
    }
}