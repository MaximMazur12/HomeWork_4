using HomeWork4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public static class PasswordGenerator
    {
        private static char[] allowedSymbols = { 'f', '@', '!', ']', '>', '/', '*', '%' };

        public static string Generate(int length)
        {
            var random = new Random();
            var password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = allowedSymbols[random.Next(allowedSymbols.Length)];
            }

            return new string(password);
        }
    }
}
