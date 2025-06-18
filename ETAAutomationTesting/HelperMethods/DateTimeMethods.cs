using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.HelperMethods
{
    public class DateTimeMethods
    {
        public DateTime FormatDate(string date)
        {
            var values = date.Split('/').Select(int.Parse).ToArray();
            var day = values[0];
            var month = values[1];
            var year = values[2];

            var currentDate = DateTime.Now;
            var formattedDate = currentDate.AddDays(day).AddMonths(month).AddYears(year);
            return formattedDate;
        }
    }
}
