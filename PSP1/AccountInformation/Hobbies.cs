using System;
using System.Text.RegularExpressions;

namespace Template
{
    class Hobbies : AccountBioValidation
    {
        public override Regex GenerateRegex()
        {
            Info();
            MaxLenght();
            MinLenght();
            Regex regex = new Regex(@".{3,20}");
            return regex;
        }

        public override void MaxLenght()
        {
            Console.WriteLine("Max symbols number: 20");
        }

        public override void MinLenght()
        {
            Console.WriteLine("Min symbols number: 3");
        }

        public override void Info()
        {
            Console.WriteLine("Hobbies regex created");
        }
    }
}
