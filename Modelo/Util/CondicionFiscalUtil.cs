using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Util
{
    public class CondicionFiscalUtil
    {
        private static readonly List<CondicionFiscal> listaCondiciones = new List<CondicionFiscal>() { 
            CondicionFiscal.CONSUMIDOR_FINAL,
            CondicionFiscal.MONOTRIBUTISTA,
            CondicionFiscal.RESPONSABLE_INSCRIPTO
        };

        public static ReadOnlyCollection<CondicionFiscal> ListaCondiciones => listaCondiciones.AsReadOnly();

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
