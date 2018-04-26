using System;

namespace Task1.Solution.CheckCases
{
    public class CheckPasswordIsEmpty : ICheckCase
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password == String.Empty)
            {
                return Tuple.Create(false, $"{password} is empty ");
            }

            return Tuple.Create(true, password);
        }
    }
}