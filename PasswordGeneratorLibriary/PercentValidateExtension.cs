using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibriary.Extension
{
    public static class PercentValidateExtension
    {
        public static int ValidatePersent(this int specialCharPersent)
        {
            if (specialCharPersent > 100)
            {
                specialCharPersent = 100;
            }
            else if (specialCharPersent < 0)
            {
                specialCharPersent = 0;
            }

            return specialCharPersent;
        }
    }
}
