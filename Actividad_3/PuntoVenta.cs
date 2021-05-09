using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    class PuntoVenta
    {
        List<Factura> listaFacturas;

        public PuntoVenta()
        {
            this.listaFacturas = new List<Factura>();
        }
        internal List<Factura> ListaFacturas { get => listaFacturas; set => listaFacturas = value; }

        public void AgregarFactura(Factura fac)
        {
            ListaFacturas.Add(fac);
        }
    }
}
