using System;
using System.Text.RegularExpressions;

namespace Template
{
    class LifeStory : AccountBioValidation
    {
        public override Regex GenerateRegex()
        {
            Info();
            MaxLenght();
            MinLenght();
            Regex regex = new Regex(@".{1,15}");
            return regex;
        }

        public override void MaxLenght()
        {
            Console.WriteLine("Max symbols number: 15");
        }

        public override void MinLenght()
        {
            Console.WriteLine("Min symbols number: 1");
        }

        public override void Info()
        {
            Console.WriteLine("Life story regex created");
        }
    }
}
