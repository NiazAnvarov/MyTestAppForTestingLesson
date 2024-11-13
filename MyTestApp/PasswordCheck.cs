using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyTestApp
{
    public class PasswordCheck
    {
        public string ValidatePassword(string Password, string Login)
        {
            
            
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrWhiteSpace(Password) ||Password.Length < 8 || Password.Length > 20 || !Password.Any(char.IsLower) || !Password.Any(char.IsUpper) || !Password.Any(char.IsDigit) || Password.Intersect("!@#$%^&/;:_`~='*{}[]()-+").Count() == 0)
                error.Append("Не верный пароль!");
            

            if (string.IsNullOrWhiteSpace(Login)/* || Password.IndexOf(" ")>= 0*/)
            {
                error.Append(" Не верный логин!");
            }


            if (error.Length != 0)
            {

                return error.ToString();
            }
            else
                return "Успех";
        }
    }
}
