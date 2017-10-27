using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Strategy
{
    interface DateStrategy
    {
        Regex GenerateRegex();
        string YearsLength(int number);
        string Separators(string separators);
        string Positions(List<string> positions);
        string Rules();
    }
}