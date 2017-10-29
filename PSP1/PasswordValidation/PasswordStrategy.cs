using System.Text.RegularExpressions;

namespace Template
{
    abstract class PasswordStrategy
    {
        public abstract Regex GenerateRegex();
        public abstract string MinLenght(int number);
        public abstract string NumberOfCaps(int number);
        public abstract string NumberOfNumbers(int number);
        public abstract string Rules();
    }
}