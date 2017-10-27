using System.Text.RegularExpressions;

namespace Strategy
{
    interface PasswordStrategy
    {
        Regex GenerateRegex();
        string MinLenght(int number);
        string NumberOfCaps(int number);
        string NumberOfNumbers(int number);
        string Rules();
    }
}