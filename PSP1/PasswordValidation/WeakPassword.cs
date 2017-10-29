using System.Text.RegularExpressions;

namespace Template
{
    class WeakPassword : PasswordStrategy
    {
        private int _length = 6;
        private int _caps = 0;
        private int _numbers = 0;

        public override Regex GenerateRegex()
        {
            return new Regex(NumberOfCaps(_caps) + NumberOfNumbers(_numbers) + MinLenght(_length));
        }

        public override string MinLenght(int number)
        {
            return ".{" + number.ToString() + ",}";
        }

        public override string NumberOfCaps(int number)
        {
            string temp = "";
            for (int i = 0; i < number; i++)
            {
                temp += ".*[A-Z]";
            }

            if (number < 1)
            {
                return temp;
            }
            else
            {
                return "(?=" + temp + ")";
            }
        }

        public override string NumberOfNumbers(int number)
        {
            string temp = "";
            for (int i = 0; i < number; i++)
            {
                temp += ".*[0-9]";
            }

            if (number < 1)
            {
                return temp;
            }
            else
            {
                return "(?=" + temp + ")";
            }
        }

        public override string Rules()
        {
            return "Length of password at least: " + _length.ToString() + "\n" +
                   "Number of capital letters required: " + _caps.ToString() + "\n" +
                   "Number of numbers required: " + _numbers.ToString() + "\n";
        }
    }
}
