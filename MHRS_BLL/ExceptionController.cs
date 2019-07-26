using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS_DAL;
using MHRS_DTO_;
using MHRS_Entity;

namespace MHRS_BLL
{
    public class PasswordLenghtException : Exception
    {
        public override string Message
        {
            get
            {
                return "Password should be min. 8 characters and max. 16 characters";
            }
        }
    }

    public class SpecialCharactersException : Exception
    {
        public override string Message
        {
            get
            {
                return "You cannot use special character";
            }
        }
    }

    public class EmailRegisteredException : Exception
    {
        public override string Message
        {
            get
            {
                return "This E-mail address is already registered";
            }
        }
    }

    public class EmailEnterException : Exception
    {
        public override string Message
        {
            get
            {
                return "Please enter a valid E-mail";
            }
        }
    }

    public class EmailBlankException : Exception
    {
        public override string Message
        {
            get
            {
                return "You cannot enter a blank E-mail";
            }
        }
    }

    public class NameBlankException : Exception
    {
        public override string Message
        {
            get
            {
                return "You cannot enter a blank Name";
            }
        }
    }

    public class SurnameBlankException : Exception
    {
        public override string Message
        {
            get
            {
                return "You cannot enter a blank Surname";
            }
        }
    }

    public class PasswordBlankException : Exception
    {
        public override string Message
        {
            get
            {
                return "You cannot enter a blank Password";
            }
        }
    }
}

