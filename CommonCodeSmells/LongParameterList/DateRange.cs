using System;

namespace CommonCodeSmells.Better_LongParameterList
{
    public class DateRange
    {
        public DateRange(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }
    }
}