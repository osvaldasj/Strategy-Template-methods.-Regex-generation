using System;
using System.Text.RegularExpressions;

namespace Template
{
    class StrongPasswordRegex : AccountCreationValidation
    {
        public override Regex GenerateRegex()
        {
            WriteState();
            SetMaxLenght();
            SetMinLenght();
            Regex regex = new Regex(@"((?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8})");
            return regex;
        }

        public override void SetMaxLenght()
        {
            Console.WriteLine("Max length: 127");
        }

        public override void SetMinLenght()
        {
            Console.WriteLine("Min length: 8");
        }

        public override void WriteState()
        {
            Console.WriteLine("Strong password regex created");
        }
    }
}
