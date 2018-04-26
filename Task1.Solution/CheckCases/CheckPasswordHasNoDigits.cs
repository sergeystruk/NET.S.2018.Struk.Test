using System;
using System.Linq;

namespace Task1.Solution.CheckCases
{
    public class CheckPasswordHasNoDigits : ICheckCase
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (!password.Any(char.IsNumber))
            {
                return Tuple.Create(false, $"{password} hasn't digits");
            }

            return Tuple.Create(true, password);
        }
    }
}