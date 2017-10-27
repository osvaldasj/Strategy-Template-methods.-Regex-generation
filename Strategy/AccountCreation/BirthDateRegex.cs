using System;
using System.Text.RegularExpressions;

namespace Strategy
{
    class BirthDateRegex : AccountCreationValidation
    {
        public Regex GenerateRegex()
        {
            WriteState();
            SetMaxLenght();
            SetMinLenght();
            Regex regex = new Regex(@"((?:0[1-9])|(?:1[0-2]))\/((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/(\d{4})");
            return regex;
        }

        public void SetMaxLenght()
        {
            Console.WriteLine("Max length: 8");
        }

        public void SetMinLenght()
        {
            Console.WriteLine("Min length: 8");
        }

        public void WriteState()
        {
            Console.WriteLine("BirthDate regex created");
        }
    }
}
