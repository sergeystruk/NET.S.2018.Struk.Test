using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] passwords = {String.Empty, "asdf", "asdfghjklasdfasdfasdf", "asdf1234"};

            PasswordChecker passwordChecker = new PasswordChecker(PasswordChecker.VerifyPasswordIsEmpty,
                PasswordChecker.VerifyPasswordHasNoChars,
                PasswordChecker.VerifyPasswordHasNoNumbers, PasswordChecker.VerifyPasswordIsBigger,
                PasswordChecker.VerifyPasswordIsSmall); 

            
            PasswordCheckerService service = new PasswordCheckerService(new SqlRepository(), passwordChecker);

            foreach (var item in passwords)
            {
                System.Console.WriteLine(service.VerifyPassword(item));
            }
            
        }
    }
}
