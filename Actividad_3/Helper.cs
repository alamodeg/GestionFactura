using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    public static class Helper
    {
        public static string LineaFactura()
        {
            return "\n-------------------------------------\n";
        }
        public static string Descripciones()
        {
            return $"PRODUCTO       CANTIDAD        TOTAL\n\n";
        }
        public static void Error_Codigo()
        {
            Console.WriteLine($"El codigo no corresponde a ningun producto");
        }
    }
}
