using System.Text.RegularExpressions;

namespace Strategy
{
    interface AccountBioValidation
    {
        Regex GenerateRegex();
        void MaxLenght();
        void MinLenght();
        void Info();
    }
}
