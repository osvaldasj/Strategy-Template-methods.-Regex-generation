using System;
using System.Text.RegularExpressions;

namespace Template
{
    class BirthDateRegex : AccountCreationValidation
    {
        public override Regex GenerateRegex()
        {
            WriteState();
            SetMaxLenght();
            SetMinLenght();
            Regex regex = new Regex(@"((?:0[1-9])|(?:1[0-2]))\/((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/(\d{4})");
            return regex;
        }

        public override void SetMaxLenght()
        {
            Console.WriteLine("Max length: 8");
        }

        public override void SetMinLenght()
        {
            Console.WriteLine("Min length: 8");
        }

        public override void WriteState()
        {
            Console.WriteLine("BirthDate regex created");
        }
    }
}
