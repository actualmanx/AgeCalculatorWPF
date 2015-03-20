using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows; // for messagebox

namespace Age_Calc
{
    class CalcClass
    {
        private DateTime dateTime1 { get; set; }
        private DateTime dateTime2 { get; set; }

        public CalcClass(string date1, string date2)
        {
            dateTime1 = Convert.ToDateTime(date1);
            dateTime2 = Convert.ToDateTime(date2);
        }

        public string getAge()
        {
            string age = "";

            TimeSpan ts = dateTime2.Subtract(dateTime1); // time difference
            int t = ts.Days; // covertring to days
            int y, m, d; // y = years, m = months, d = days

            y = t / 365; 
            t = t % 365;

            m = t / 30;
            d = t % 30;

            age += y + " years " + m + " months " + d + " days";

            return age;
        }
    }
}
