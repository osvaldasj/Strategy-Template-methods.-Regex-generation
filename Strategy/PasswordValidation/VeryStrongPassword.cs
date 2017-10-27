using System.Text.RegularExpressions;

namespace Strategy
{
    class VeryStrongPassword : PasswordStrategy
    {
        private int _length = 20;
        private int _caps = 4;
        private int _numbers = 4;

        public Regex GenerateRegex()
        {
            return new Regex(NumberOfCaps(_caps) + "(?=.*[._!@#$&*])" + NumberOfNumbers(_numbers) + MinLenght(_length));
        }

        public string MinLenght(int number)
        {
            return ".{" + number.ToString() + ",125}";
        }

        public string NumberOfCaps(int number)
        {
            string temp = "";
            for (int i = 0; i < number; i++)
            {
                temp += ".*[A-Z]";
            }
            return "(?=" + temp + ")";
        }

        public string NumberOfNumbers(int number)
        {
            string temp = "";
            for (int i = 0; i < number; i++)
            {
                temp += ".*[0-9]";
            }
            return "(?=" + temp + ")";
        }

        public string Rules()
        {
            return "Length of password: " + _length.ToString() + " - 125" + "\n" +
                   "Number of capital letters required: " + _caps.ToString() + "\n" +
                   "Number of numbers required: " + _numbers.ToString() + "\n" +
                   "Special symbols (._!@#$&*) required" + "\n";
        }
    }
}
