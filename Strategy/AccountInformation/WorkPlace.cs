using System;
using System.Text.RegularExpressions;

namespace Strategy
{
    class WorkPlace : AccountBioValidation
    {
        public Regex GenerateRegex()
        {
            Info();
            MaxLenght();
            MinLenght();
            Regex regex = new Regex(@".{3,10}");
            return regex;
        }

        public void MaxLenght()
        {
            Console.WriteLine("Max symbols number: 10");
        }

        public void MinLenght()
        {
            Console.WriteLine("Min symbols number: 3");
        }

        public void Info()
        {
            Console.WriteLine("Work place regex created");
        }
    }
}
