using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Strategy
{
    class YearsMonthsDays : DateStrategy
    {
        private int _yearsLength = 4;
        private string _separators = ". ";
        private List<string> _positions = new List<string>() { "Months", "Days", "Years" };

        public Regex GenerateRegex()
        {
            string regex = Positions(_positions).Replace(" ", Separators(_separators));
            regex = regex.Replace("D", "[0-9]");
            regex = regex.Replace("M", "[0-9]");
            regex = regex.Replace("Y", "[0-9]");

            return new Regex(regex);
        }

        public string Positions(List<string> positions)
        {
            string temp = "";
            positions.Reverse();
            foreach (var dateType in positions)
            {
                switch (dateType)
                {
                    case "Days":
                        temp = temp + "DD ";
                        break;
                    case "Years":
                        temp = temp + YearsLength(_yearsLength) + " ";
                        break;
                    default:
                        temp = temp + "MM ";
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
