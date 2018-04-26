using System;

namespace Task1.Solution.CheckCases
{
    public class CheckPasswordIsSmall : ICheckCase
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password.Length <= 7)
            {
                return Tuple.Create(false, $"{password} length too short");
            }

            return Tuple.Create(true, password);
        }
    }
}