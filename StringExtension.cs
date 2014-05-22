using System;
using System.Text.RegularExpressions;

namespace superconverter
{
    public static class StringExtension
    {
        static Regex ipRegex = new Regex("^-?\\d+$");
        static Regex versionRegex = new Regex("^\\d+$");
        static Regex timeRegex = new Regex("^\\d+$");
        static Regex utcTimeRegex = new Regex("^\\d+$");

        public static bool IsIp(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return ipRegex.IsMatch(input);
        }

        public static bool IsVersion(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return versionRegex.IsMatch(input);
        }

        public static bool IsTime(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return timeRegex.IsMatch(input);
        }

        public static bool IsUTCTime(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return utcTimeRegex.IsMatch(input);
        }

        public static string ToIp(this string input)
        {
            string output = "";
            try
            {
                var n = UInt32.Parse(input);
                var a = (byte)((n & 0xFF000000) >> 24);
                var b = (byte)((n & 0x00FF0000) >> 16);
                var c = (byte)((n & 0x0000FF00) >> 8);
                var d = (byte)(n & 0x000000FF);
                output = String.Format("{0}.{1}.{2}.{3}", d, c, b, a);
            }
            catch (Exception)
            {
                var n = Int32.Parse(input);
                var a = (byte)((n & 0xFF000000) >> 24);
                var b = (byte)((n & 0x00FF0000) >> 16);
                var c = (byte)((n & 0x0000FF00) >> 8);
                var d = (byte)(n & 0x000000FF);
                output = String.Format("{0}.{1}.{2}.{3}", d, c, b, a);
            }
            return output;
        }

        public static string ToVersion(this string input)
        {
            var n = UInt32.Parse(input);
            var a = (byte)((n & 0xFF000000) >> 24);
            var b = (byte)((n & 0x00FF0000) >> 16);
            var c = (byte)((n & 0x0000FF00) >> 8);
            var d = (byte)(n & 0x000000FF);

            return String.Format("{0}.{1}.{2}.{3}", a, b, c, d);
        }

        public static string ToTime(this string input)
        {
            return TimeZone.CurrentTimeZone
                           .ToLocalTime(new System.DateTime(1970, 1, 1))
                           .AddSeconds(UInt32.Parse(input))
                           .ToString();
        }

        public static string ToUTCTime(this string input)
        {
            var startTime = new System.DateTime(1970, 1, 1);
            return startTime.AddSeconds(UInt32.Parse(input))
                            .ToString();
        }

        public static string UTCToInt(this string input)
        {
            var output = "";
            var dt = DateTime.Parse(input);
            var ts1970 = new TimeSpan(DateTime.Parse("1970/1/1 00:00:00").Ticks);
            var ts = new TimeSpan(dt.Ticks);

            output = ts.Subtract(ts1970)
                       .Duration()
                       .TotalSeconds
                       .ToString();

            return output;
        }

        public static string LocalTimeToInt(this string input)
        {
            var output = "";
            var dt = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Parse(input));
            var ts1970 = new TimeSpan(DateTime.Parse("1970/1/1 00:00:00").Ticks);
            var ts = new TimeSpan(dt.Ticks);

            output = ts.Subtract(ts1970)
                       .Duration()
                       .TotalSeconds
                       .ToString();

            return output;
        }
    }
}
