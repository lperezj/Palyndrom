using System;

namespace Palyndrom
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string cadenaToCheck = "Never odd or even!";
            
            bool bOk = IsPalyndrom(cadenaToCheck);
            Console.WriteLine($"{cadenaToCheck}:{bOk}");
        }

        static bool IsPalyndrom(string cadena)
        {
            string pattern = @"(\s+|@|&|'|\(|\)|<|>|#|!)";
            cadena = Regex.Replace(cadena.ToLower(), pattern, "");

            if (cadena.Length < 2) return true;

            if (cadena[0].Equals(cadena[cadena.Length - 1]))
            {
                return IsPalyndrom(cadena.Substring(1, cadena.Length - 2));
            }

            return false;
        }
    }
}
