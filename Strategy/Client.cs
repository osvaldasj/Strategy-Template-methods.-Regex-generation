using System;
using System.Text.RegularExpressions;

namespace Strategy
{
    class Client
    {
        private string _name = "not known information";
        private string _lastName = "not known information";
        private string _password = "not known information";
        private string _email = "not known information";
        private string _phoneNumber = "not known information";
        private string _date = "not known information";
        private string _hobbies = "not known information";
        private string _lifeStory = "not known information";
        private string _workPlace = "not known information";

        public Client()
        {
            _name = Name();
            _lastName = LastName();
            _email = Email();
            _phoneNumber = Phone();
            _date = Date();
            _password = Password();
        }

        public void AdditionalInfo()
        {
            _hobbies = Hobbies();
            _lifeStory = Life();
            _workPlace = Work();
        }

        private string Name()
        {
            Console.WriteLine("Enter name:");
            return Console.ReadLine();
        }

        private string LastName()
        {
            Console.WriteLine("Enter last name:");
            return Console.ReadLine();
        }

        public string ValidateCreationData(string text, PasswordStrategy regex)
        {
            if (CheckValidation(text, regex.GenerateRegex()))
            {
                return text;
            }
            else
            {
                return "Error";
            }
        }

        public string ValidateBioData(string text, AccountBioValidation regex)
        {
            if (CheckValidation(text, regex.GenerateRegex()))
            {
                return text;
            }
            else
            {
                return "Error";
            }
        }

        private string Email()
        {
            Console.WriteLine("Enter email address:");
            string temp = Console.ReadLine();
            PasswordStrategy regex = new StrongPassword();

            if (ValidateCreationData(temp, regex) != "Error")
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Try again");
                return Email();
            }
        }

        private string Phone()
        {
            Console.WriteLine("Enter phone number:");
            string temp = Console.ReadLine();
            PasswordStrategy regex = new NormalPassword();

            if (ValidateCreationData(temp, regex) != "Error")
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Try again");
                return Phone();
            }
        }

        private string Password()
        {
            Console.WriteLine("Enter password:");
            string temp = Console.ReadLine();
            PasswordStrategy regex = new StrongPasswordRegex();

            if (ValidateCreationData(temp, regex) != "Error")
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Try again");
                return Password();
            }
        }

        private string Date()
        {
            Console.WriteLine("Enter birth date MM/DD/YYYY:");
            string temp = Console.ReadLine();
            PasswordStrategy regex = new WeakPassword();

            if (ValidateCreationData(temp, regex) != "Error")
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Try again");
                return Date();
            }
        }

        private string Hobbies()
        {
            Console.WriteLine("Enter hobbies:");
            string temp = Console.ReadLine();
            AccountBioValidation regex = new Hobbies();

            if (ValidateBioData(temp, regex) != "Error")
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Try again");
                return Hobbies();
            }
        }

        private string Life()
        {
            Console.WriteLine("Enter life story:");
            string temp = Console.ReadLine();
            AccountBioValidation regex = new LifeStory();

            if (ValidateBioData(temp, regex) != "Error")
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Try again");
                return Life();
            }
        }

        private string Work()
        {
            Console.WriteLine("Enter work place:");
            string temp = Console.ReadLine();
            AccountBioValidation regex = new WorkPlace();

            if (ValidateBioData(temp, regex) != "Error")
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Try again");
                return Work();
            }
        }



        private bool CheckValidation(string text, Regex regex)
        {
            if (regex.IsMatch(text))
            {
                return true;
            }
            return false;
        }

        public void Info()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_lastName);
            Console.WriteLine(_email);
            Console.WriteLine(_phoneNumber);
            Console.WriteLine(_date);
            Console.WriteLine(_password);
            Console.WriteLine(_hobbies);
            Console.WriteLine(_workPlace);
            Console.WriteLine(_lifeStory);
        }
    }
}
