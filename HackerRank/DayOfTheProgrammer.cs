using System.Globalization;

class DayOfTheProgrammer
{
    public static string dayOfProgrammer(int year)
    {
        GregorianCalendar gregorianCalendar = new GregorianCalendar();
        JulianCalendar julianCalendar = new JulianCalendar();
        DateTime dateTime;

        int programmerDay = 256;
        int sumDaysInMonth = 0;
        int month = 8;
        
        for (int m = 1; m <= month; m++)
        {
            if (year >= 1919 && year <= 2700)
            {
                sumDaysInMonth += gregorianCalendar.GetDaysInMonth(year, m);
            }

            if (year >= 1700 && year <= 1917)
            {
       
                sumDaysInMonth += julianCalendar.GetDaysInMonth(year, m);

            }
            if (year == 1918)
            {
                if (m == 2)
                {
                    sumDaysInMonth += julianCalendar.GetDaysInMonth(year, m);
                    sumDaysInMonth -= 13;

                }
                else
                {
                    sumDaysInMonth += julianCalendar.GetDaysInMonth(year, m);

                }


            }

        }

        int day = programmerDay - sumDaysInMonth;
        dateTime = new DateTime(year, month+1, day);
        string fullDate = dateTime.ToString("dd.MM.yyyy");
        Console.WriteLine(fullDate);

        return "";

    }


}
class ProblemDayOfTheProgrammer
{
    public static int year1 = 2017;
    public static int year2 = 2016;
    public static int year3 = 1918;


}

