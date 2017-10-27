using System;
using System.Text.RegularExpressions;

namespace Strategy
{
    class LifeStory : AccountBioValidation
    {
        public Regex GenerateRegex()
        {
            Info();
            MaxLenght();
            MinLenght();
            Regex regex = new Regex(@".{1,15}");
            return regex;
        }

        public void MaxLenght()
        {
            Console.WriteLine("Max symbols number: 15");
        }

        public void MinLenght()
        {
            Console.WriteLine("Min symbols number: 1");
        }

        public void Info()
        {
            Console.WriteLine("Life story regex created");
        }
    }
}
