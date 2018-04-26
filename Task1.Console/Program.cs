using System;
using System.Collections.Generic;
using Task1.Solution;
using Task1.Solution.CheckCases;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] passwords = {String.Empty, "asdf", "asdfghjklasdfasdfasdf", "asdf1234"};

            List<ICheckCase> cases = new List<ICheckCase>();
            cases.Add(new CheckPasswordHasNoChars());
            cases.Add(new CheckPasswordHasNoDigits());
            cases.Add(new CheckPasswordIsBig());
            cases.Add(new CheckPasswordIsSmall());
            cases.Add(new CheckPasswordIsEmpty());

            PasswordCheckerService service = new PasswordCheckerService(new SqlRepository(), cases);

            foreach (var item in passwords)
            {
                System.Console.WriteLine(service.VerifyPassword(item).Item2);
            }
        }
    }
}
