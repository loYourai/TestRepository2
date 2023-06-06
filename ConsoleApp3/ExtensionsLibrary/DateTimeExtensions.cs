namespace ExtensionsLibrary
{
    public static class DateTimeExtensions
    {
        public static string ToBeetrotFormat(this DateTime dateTime)
        {
            return dateTime.ToString("ddmmyyyy");
        }

        public static int GetDaysBetween(this DateTime dateTime, DateTime targetDate)
        {
            if (dateTime == DateTime.MinValue)
            {
                throw new ArgumentException("dateTime is not initialized!");
            }

            if (targetDate == DateTime.MinValue)
            {
                throw new ArgumentException("dateTime is not initialized!");
            }

            var startDate = dateTime;

            if (dateTime.Hour > 18)
            {
                startDate = dateTime.Date.AddDays(1);
            }

            return startDate.GetDaysBetween(targetDate);
        }
    }
}
