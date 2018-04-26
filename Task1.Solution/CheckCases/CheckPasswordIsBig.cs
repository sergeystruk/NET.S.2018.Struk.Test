using System;

namespace Task1.Solution.CheckCases
{
    public class CheckPasswordIsBig : ICheckCase
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password.Length >= 15)
            {
                return Tuple.Create(false, $"{password} length too long");
            }

            return Tuple.Create(true, password);
        }
    }
}