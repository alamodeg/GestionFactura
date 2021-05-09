using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    class Factura
    {
        class Linea
        {
            Producto producto;
            float importe;
            int cantidad;

            public Linea(Producto producto, int cantidad, float importe)
            {
                this.producto = producto;
                this.importe = importe;
                this.cantidad = cantidad;
            }

            public float Importe { get => importe; set => importe = value; }
            public int Cantidad { get => cantidad; set => cantidad = value; }
            internal Producto Producto { get => producto; set => producto = value; }
        }

        int codFactura;
        List<Linea> listadoLineas;
        Catalogo catalogo;
        float precioFinal;


        static private int _codigo = 0;

        public int CodFactura { get => codFactura; set => codFactura = value; }
        private List<Linea> ListadoLineas { get => listadoLineas; set => listadoLineas = value; }
        internal Catalogo Catalogo { get => catalogo; set => catalogo = value; }
        public float PrecioFinal { get => precioFinal; set => precioFinal = value; }

        public Factura(Catalogo catalogo)
        {
            this.CodFactura = _codigo++;
            this.ListadoLineas = new List<Linea>();
            this.Catalogo = catalogo;
        }

        public void Vender(int codigo, int _cantidad)
        {
            Producto prod = Catalogo.Buscar(codigo);
            bool flag = false;
           
            if (ListadoLineas.Any())
            {
                foreach (var linea in ListadoLineas)
                {
                    //si ya esta el producto en la linea actualiza
                    if (linea.Producto == prod)
                    {
                        linea.Cantidad += _cantidad; //actualiza cantidad
                        linea.Importe += prod.Precio * _cantidad; //actualiza el precio
                        flag = true; 
                        break;
                    }
                }
                if (!flag)
                {
                    ListadoLineas.Add(new Linea(prod, _cantidad, prod.Precio * _cantidad));
                }
            }
            else ListadoLineas.Add(new Linea(prod, _cantidad, prod.Precio * _cantidad));
        }
        public string Mostrar()
        {
            string cad="";
            float total = ListadoLineas.Sum(lin => lin.Importe); //query && lambda exp
            cad += Helper.LineaFactura();
            cad = $"Factura N° {CodFactura} \n\n";
            cad += Helper.Descripciones();

            foreach (var l in ListadoLineas)
            {
                cad += $"{l.Producto.Descripcion}    --    {l.Cantidad} Unidades   --    ${l.Importe} \n";
            }
            cad += $"\nImporte total a abonar....... ${total}";
            cad += Helper.LineaFactura();
            return cad;
        }
    }
}
