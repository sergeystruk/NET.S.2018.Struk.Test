using System;
using System.Linq;

namespace Task1.Solution.CheckCases
{
    public class CheckPasswordHasNoChars : ICheckCase
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (!password.Any(char.IsLetter))
            {
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            }

            return Tuple.Create(true, password);
        }
    }
}