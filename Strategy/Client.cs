using System.Text.RegularExpressions;

namespace Strategy
{
    class Client
    {
        private string _firstName;
        private string _lastName;
        private string _password = "not created";
        private string _birthDate = "not known information";

        public Client(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string CreatePassword(string password, PasswordStrategy strategy)
        {
            if (CheckValidation(password, strategy.GenerateRegex()))
            {
                _password = password;
                return password;
            }
            else
            {
                return "Password isn't strong enough";
            }
        }

        public string EnterBirthDate(string birthDate, DateStrategy strategy)
        {
            if (CheckValidation(birthDate, strategy.GenerateRegex()))
            {
                _birthDate = birthDate;
                return birthDate;
            }
            else
            {
                return "Wrong date format";
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

        public string Info()
        {
            return "Name: " + _firstName + "\n" +
                   "Last name: " + _lastName + "\n" +
                   "Birth date: " + _birthDate + "\n" +
                   "Password: " + _password + "\n";
        }
    }
}
