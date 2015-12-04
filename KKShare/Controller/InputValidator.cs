using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKShare.Controller
{
    public enum ValidatePortResult
    {
        Success, Error, Error1
    }

    public class InputValidator
    {
        public ValidatePortResult validatePort(string text)
        {
            ValidatePortResult result = ValidatePortResult.Success;
            // TDOD: Regex!
            return result;
        }
    }
}
