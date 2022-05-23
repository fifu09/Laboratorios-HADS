using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion
{
    public class Validacion
    {
        public Boolean validarEmail(String email)
        {
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean validarPassword(String password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
