using System;
using System.Text.RegularExpressions;

namespace Template
{
    class EmailRegex : AccountCreationValidation
    {
        public override Regex GenerateRegex()
        {
            WriteState();
            SetMaxLenght();
            SetMinLenght();
            Regex regex = new Regex(@"(([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?))");
            return regex;
        }

        public override void SetMaxLenght()
        {
            Console.WriteLine("Max length: 254");
        }

        public override void SetMinLenght()
        {
            Console.WriteLine("Min length: 3");
        }

        public override void WriteState()
        {
            Console.WriteLine("Email regex created");
        }
    }
}
