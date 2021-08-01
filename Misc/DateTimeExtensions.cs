using System;
using System.Collections.Generic;
using System.Text;

namespace Misc
{
    public static class DateTimeExtensions
    {
        public static DateTime Default(this DateTime date)   
        {
            if (date == null || date == new DateTime(1, 1, 1))
            {
                return new DateTime(1900, 1, 1);
            }
            else
            {
                return date;
            }

        }
    }
}
