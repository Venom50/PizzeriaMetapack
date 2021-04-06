using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pizzeria.Helpers
{
    public class Helper
    {
        /// <summary>
        /// Checks if email is valid
        /// </summary>
        /// <param name="email">Email to be validated</param>
        /// <returns>True if email is valid, otherwise false</returns>
        public static bool CheckIfEmailIsCorrect(string email)
        {
            Regex regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",
                RegexOptions.IgnoreCase);

            return regex.IsMatch(email);
        }
    }
}
