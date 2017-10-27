using System.Text.RegularExpressions;

namespace Template
{
    abstract class AccountCreationValidation
    {
        public abstract Regex GenerateRegex();
        public abstract void SetMaxLenght();
        public abstract void SetMinLenght();
        public abstract void WriteState();
    }
}
