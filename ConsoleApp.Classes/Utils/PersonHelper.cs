using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes.Utils
{
    public static class PersonHelper
    {
        public static string GenerateIdNumber(string prefix)
        {
            var randomNumber = RandomNumberGenerator.GetInt32(000000, 999999).ToString();
            return $"Id Number is {prefix}-{randomNumber}";
        }
    }
}
