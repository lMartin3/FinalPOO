using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Util
{
    public class CondicionFiscalUtil
    {
        private static readonly Dictionary<String, CondicionFiscal> condiciones = new Dictionary<String, CondicionFiscal>() {
            { "CONSUMIDOR FINAL", CondicionFiscal.CONSUMIDOR_FINAL },
            { "MONOTRIBUTISTA", CondicionFiscal.MONOTRIBUTISTA },
            { "RESPONSABLE INSCRIPTO", CondicionFiscal.RESPONSABLE_INSCRIPTO },
        };

        public static String[] CondicionesComoStrings()
        {
            
                return condiciones.Keys.ToArray();
            
        }

        public static CondicionFiscal? CondicionPorString(String str)
        {
            if(condiciones.ContainsKey(str))
            {
                return condiciones[str];
            }
            return null;
        }
    }
}
