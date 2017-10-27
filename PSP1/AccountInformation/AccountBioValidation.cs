using System.Text.RegularExpressions;

namespace Template
{
    abstract class AccountBioValidation
    {
        public abstract Regex GenerateRegex();
        public abstract void MaxLenght();
        public abstract void MinLenght();
        public abstract void Info();
    }
}
