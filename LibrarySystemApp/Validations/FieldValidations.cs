using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp.Validations
{
    public class FieldValidations
    {
        public static bool ValidateLetters(KeyPressEventArgs e)
        {
            bool value;

            if (Char.IsLetter(e.KeyChar))
            {
                value = false;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                value = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                value = false;
            }
            else
            {
                value = true;
            }

            return value;
        }

        public static bool ValidateNumbers(KeyPressEventArgs e)
        {
            bool value;

            if (Char.IsDigit(e.KeyChar))
            {
                value = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                value = false;
            }
            else
            {
                value = true;
            }

            return value;
        }
    }
}
