using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1.Solution
{
    public class PasswordChecker
    {
        internal List<Func<string, Tuple<bool, string>>> validator;

        internal List<Tuple<bool, string>> checks;

        public PasswordChecker(params Func<string, Tuple<bool, string>>[] validers)
        {
            validator = new List<Func<string, Tuple<bool, string>>>();
            foreach (var item in validers)
            {
                validator.Add(item);
            }
        }

        public static Tuple<bool, string> VerifyPasswordIsEmpty(string password)
        {
            if (password == String.Empty)
            {
                return Tuple.Create(false, $"{password} is empty ");
            }

            return Tuple.Create(true, password);
        }

        public static Tuple<bool, string> VerifyPasswordIsSmall(string password)
        {
            if (password.Length <= 7)
            {
                return Tuple.Create(false, $"{password} length too short");
            }

            return Tuple.Create(true, password);
        }

        public static Tuple<bool, string> VerifyPasswordIsBigger(string password)
        {
            if (password.Length >= 15)
            {
                return Tuple.Create(false, $"{password} length too long");
            }

            return Tuple.Create(true, password);
        }

        public static Tuple<bool, string> VerifyPasswordHasNoChars(string password)
        {
            if (!password.Any(char.IsLetter))
            {
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            }

            return Tuple.Create(true, password);
        }

        public static Tuple<bool, string> VerifyPasswordHasNoNumbers(string password)
        {
            if (!password.Any(char.IsNumber))
            {
                return Tuple.Create(false, $"{password} hasn't digits");
            }

            return Tuple.Create(true, password);
        }
    }
}