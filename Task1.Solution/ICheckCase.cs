using System;

namespace Task1.Solution
{
    public interface ICheckCase
    {
        Tuple<bool, string> Validate(string password);
    }
}