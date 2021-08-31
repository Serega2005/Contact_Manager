using System;
//using System.Buffers;

namespace ContactManager
{
    [Serializable]
    public class DateOfBirth
    {
        public uint YearBirth { get; set; }
        public uint MonthBirth { get; set; }
        public uint DayBirth { get; set; }
        public DateOfBirth() { }
        ~DateOfBirth() { }
        public DateOfBirth(uint year, uint month, uint day)
        {
            YearBirth = year;
            MonthBirth = month;
            DayBirth = day;
        }

        public uint AgeNow()
        {
            int age = 0;
            DateTime today = DateTime.Today;
            DateTime birth = new DateTime(Convert.ToInt32(YearBirth), Convert.ToInt32(MonthBirth),
                Convert.ToInt32(DayBirth));
            age = today.Year - birth.Year;
            if (today.Month < birth.Month || (today.Month == birth.Month && today.Day < birth.Day))
            {
                age--;
            }

            return Convert.ToUInt32(age);
        }
    }
}