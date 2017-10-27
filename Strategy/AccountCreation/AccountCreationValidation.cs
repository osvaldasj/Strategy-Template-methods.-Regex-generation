using System.Text.RegularExpressions;

namespace Strategy
{
    interface AccountCreationValidation
    {
        Regex GenerateRegex();
        void SetMaxLenght();
        void SetMinLenght();
        void WriteState();
    }
}
