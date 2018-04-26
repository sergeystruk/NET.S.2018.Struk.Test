using System;
using System.Collections.Generic;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        #region Fields

        private IRepository repository;
        private IEnumerable<ICheckCase> cases;

        #endregion

        #region Constructors

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public PasswordCheckerService(IEnumerable<ICheckCase> cases)
        {
            this.cases = cases;
        }

        public PasswordCheckerService() : this(new SqlRepository()) { }

        public PasswordCheckerService(IRepository repository, IEnumerable<ICheckCase> cases) : this(repository) =>
            this.cases = cases;

        #endregion

        #region API

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (ReferenceEquals(password, null))
            {
                throw new ArgumentNullException(nameof(password));
            }

            if (ReferenceEquals(cases, null))
            {
                throw new ArgumentNullException(nameof(cases));
            }

            foreach (var item in cases)
            {
                if (!item.Validate(password).Item1)
                {
                    return item.Validate(password);
                }
            }

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }

        #endregion
    }
}