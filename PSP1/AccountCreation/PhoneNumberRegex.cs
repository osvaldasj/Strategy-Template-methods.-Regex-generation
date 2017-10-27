using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Template
{
    class PhoneNumberRegex : AccountCreationValidation
    {
        public override Regex GenerateRegex()
        {
            WriteState();
            SetMaxLenght();
            SetMinLenght();
            Regex regex = new Regex(@"(\b\d{3}[-.]?\d{3}[-.]?\d{4}\b)");
            return regex;
        }

        public override void SetMaxLenght()
        {
            Console.WriteLine("Max length: 15");
        }

        public override void SetMinLenght()
        {
            Console.WriteLine("Min length: 8");
        }

        public override void WriteState()
        {
            Console.WriteLine("Phone number regex created");
        }
    }
}
