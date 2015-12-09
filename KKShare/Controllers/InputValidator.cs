using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KKShare.Controllers
{
    public enum NameResults { Valid, Error }

    public class InputValidator
    {
        internal NameResults ValidateName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]+$");
            if (regex.Match(name).Success)
            {
                return NameResults.Valid;
            }
            return NameResults.Error;
        }
    }
}
