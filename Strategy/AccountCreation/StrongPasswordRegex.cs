using System;
using System.Text.RegularExpressions;

namespace Strategy
{
    class StrongPasswordRegex : AccountCreationValidation
    {
        public Regex GenerateRegex()
        {
            WriteState();
            SetMaxLenght();
            SetMinLenght();
            Regex regex = new Regex(@"((?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8})");
            return regex;
        }

        public void SetMaxLenght()
        {
            Console.WriteLine("Max length: 127");
        }

        public void SetMinLenght()
        {
            Console.WriteLine("Min length: 8");
        }

        public void WriteState()
        {
            Console.WriteLine("Strong password regex created");
        }
    }
}
