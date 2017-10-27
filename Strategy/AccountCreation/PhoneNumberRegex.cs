using System;
using System.Text.RegularExpressions;

namespace Strategy
{
    class PhoneNumberRegex : AccountCreationValidation
    {
        public Regex GenerateRegex()
        {
            WriteState();
            SetMaxLenght();
            SetMinLenght();
            Regex regex = new Regex(@"(\b\d{3}[-.]?\d{3}[-.]?\d{4}\b)");
            return regex;
        }

        public void SetMaxLenght()
        {
            Console.WriteLine("Max length: 15");
        }

        public void SetMinLenght()
        {
            Console.WriteLine("Min length: 8");
        }

        public void WriteState()
        {
            Console.WriteLine("Phone number regex created");
        }
    }
}
