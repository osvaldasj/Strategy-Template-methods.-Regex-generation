using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Strategy
{
    class MonthsDaysYears : DateStrategy
    {
        private int _yearsLength = 2;
        private string _separators = "/";
        private List<string> _positions = new List<string>() { "Months", "Days", "Years" };

        public Regex GenerateRegex()
        {
            return new Regex(Positions(_positions).Replace(" ", "." + Separators(_separators)).Replace("D", "[0-9]").Replace("M", "[0-9]").Replace("Y", "[0-9]"));
        }

        public string Positions(List<string> positions)
        {
            string temp = "";
            foreach (var dateType in positions)
            {
                switch (dateType)
                {
                    case "Days":
                        temp += "DD ";
                        break;
                    case "Years":
                        temp += YearsLength(_yearsLength) + " ";
                        break;
                    default:
                        temp += "MM";
                        break;
                }
            }
            return temp.TrimEnd();
        }

        public string Separators(string separators)
        {
            return "[" + separators + "]";
        }

        public string YearsLength(int number)
        {
            if (number == 4)
            {
                return "YYYY";
            }
            else
            {
                return "YY";
            }
        }

        public string Rules()
        {
            return "Format of date: " + Positions(_positions) + "\n" +
                   "Allowed separators: " + _separators + "\n";
        }
    }
}
