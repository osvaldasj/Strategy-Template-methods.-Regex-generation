using System;
using System.Text.RegularExpressions;

namespace Strategy
{
    class Hobbies : AccountBioValidation
    {
        public Regex GenerateRegex()
        {
            Info();
            MaxLenght();
            MinLenght();
            Regex regex = new Regex(@".{3,20}");
            return regex;
        }

        public void MaxLenght()
        {
            Console.WriteLine("Max symbols number: 20");
        }

        public void MinLenght()
        {
            Console.WriteLine("Min symbols number: 3");
        }

        public void Info()
        {
            Console.WriteLine("Hobbies regex created");
        }
    }
}
