using System;
using System.Text.RegularExpressions;

namespace Strategy
{
    class EmailRegex : AccountCreationValidation
    {
        public Regex GenerateRegex()
        {
            WriteState();
            SetMaxLenght();
            SetMinLenght();
            Regex regex = new Regex(@"(([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?))");
            return regex;
        }

        public void SetMaxLenght()
        {
            Console.WriteLine("Max length: 254");
        }

        public void SetMinLenght()
        {
            Console.WriteLine("Min length: 3");
        }

        public void WriteState()
        {
            Console.WriteLine("Email regex created");
        }
    }
}
