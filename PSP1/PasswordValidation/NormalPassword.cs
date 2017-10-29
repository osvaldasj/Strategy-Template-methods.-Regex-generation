using System.Text.RegularExpressions;

namespace Template
{
    class NormalPassword : PasswordStrategy
    {
        private int _length = 8;
        private int _caps = 1;
        private int _numbers = 1;

        public override Regex GenerateRegex()
        {
            return new Regex(NumberOfCaps(_caps) + NumberOfNumbers(_numbers) + MinLenght(_length));
        }

        public override string MinLenght(int number)
        {
            return ".{" + number.ToString() + ",125}";
        }

        public override string NumberOfCaps(int number)
        {
            string temp = "";
            for (int i = 0; i < number; i++)
            {
                temp += ".*[A-Z]";
            }
            return "(?=" + temp + ")";
        }

        public override string NumberOfNumbers(int number)
        {
            string temp = "";
            for (int i = 0; i < number; i++)
            {
                temp += ".*[0-9]";
            }
            return "(?=" + temp + ")";
        }

        public override string Rules()
        {
            return "Length of password: " + _length.ToString() + " - 125" + "\n" +
                   "Number of capital letters required: " + _caps.ToString() + "\n" +
                   "Number of numbers required: " + _numbers.ToString() + "\n";
        }
    }
}
