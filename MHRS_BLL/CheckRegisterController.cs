using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS_BLL
{
    public class CheckRegisterController
    {
        public void CheckPassword(string password)
        {
            if (password.Length < 8 || password.Length > 16)
            {
                throw new PasswordLenghtException();
            }

            string specialCharacters = ".,:;!'^#+$%½&/{([)]=}?*-_|<>€";

            int letterCount = 0;
            foreach (char item in password)
            {
                if (specialCharacters.Contains(item))
                {
                    letterCount++;
                }

            }
            if (letterCount > 0)
            {
                throw new SpecialCharactersException();
            }
        }


    }
}
