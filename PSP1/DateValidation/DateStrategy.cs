using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Template
{
    abstract class DateStrategy
    {
        public abstract Regex GenerateRegex();
        public abstract string YearsLength(int number);
        public abstract string Separators(string separators);
        public abstract string Positions(List<string> positions);
        public abstract string Rules();
    }
}