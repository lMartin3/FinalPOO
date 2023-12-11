using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NuevoModelo.Util
{
    public class ValidacionUtil
    {
        private static Regex dniRegex = new Regex("^[0-9]{8}$");
        private static Regex cuitRegex = new Regex("^[0-9]{11}$");
        private static Regex numeroRegex = new Regex("^[0-9]{1,}$");

        public static bool EsNumeroPositivo(string input)
        {
            int res = -1;
            int.TryParse(input, out res);
            return res > 0;
        }

        public static bool EsDniValido(string input)
        {
            return dniRegex.IsMatch(input);
        }

        public static bool EsNumero(string input)
        {
            return numeroRegex.IsMatch(input);
        }

        public static bool EsCuitValido(string input)
        {
            return cuitRegex.IsMatch(input);
        }

        public  static bool EsDniOCuitValido(string input)
        {
            return EsDniValido(input) || EsCuitValido(input);
        }
    }
}
