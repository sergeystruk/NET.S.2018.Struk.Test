using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        
        private PasswordChecker passwordChecker;

        #region Constructions

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public PasswordCheckerService() : this(new SqlRepository()) { }

        //public PasswordCheckerService(IRepository repository, params Func<string, Tuple<bool, string>>[] parameters)
        //{
        //    foreach (var item in parameters)
        //    {
        //        validator.Add(item);
        //    }

        //    this.repository = repository;
        //}

        //public PasswordCheckerService(params Func<string, Tuple<bool, string>>[] parameters)
        //{
        //    foreach (var item in parameters)
        //    {
        //        validator.Add(item);
        //    }

        //    this.repository = new SqlRepository();
        //}

        public PasswordCheckerService(IRepository repos, PasswordChecker check)
        {
            repository = repos;
            passwordChecker = check;
        }

        #endregion

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (ReferenceEquals(password, null))
            {
                throw new ArgumentException($"{password} is null arg");
            }

            foreach (var item in passwordChecker.validator)
            {
                passwordChecker.checks.Add(item(password));
            }

            foreach (var tuple in passwordChecker.checks)
            {
                if (!tuple.Item1)
                {
                    return tuple;
                }
            }

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}