using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    class Program
    {
        static void Main()
        {
            var catalogo = Catalogo.Cargar();
            //Console.WriteLine(catalogo.Buscar(1)?.Descripcion); ? null no detiene app
            var Factura1 = new Factura(catalogo);
            var Factura2 = new Factura(catalogo);
            PuntoVenta Sucursal = new PuntoVenta();


            //Factura1.Vender(31,-2); //definir tratamiento del null
            Factura1.Vender(1,3);
            Factura1.Vender(1,2);
            Factura1.Vender(1,-1);
            Factura1.Vender(3,2);
            
            Factura1.Vender(2,1);

            Factura2.Vender(4, 3);
            Factura2.Vender(4, -2);


            Sucursal.AgregarFactura(Factura1); 
            Sucursal.AgregarFactura(Factura2);

            Console.WriteLine(Factura1.Mostrar());
            Console.WriteLine(Factura2.Mostrar());
            Console.ReadKey();
        }
    }
}
