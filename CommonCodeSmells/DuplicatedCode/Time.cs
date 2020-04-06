using System;

namespace CommonCodeSmells.DuplicatedCode
{
    public class Time
    {
        public int Minutes;
        public int Hours;

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public static Time Parse(string param)
        {
            if (string.IsNullOrWhiteSpace(param) || !int.TryParse(param.Replace(":", ""), out var time))
                throw new ArgumentNullException("param");

            var hours = time / 100;
            var minutes = time % 100;

            return new Time(hours, minutes);
        }
    }
}