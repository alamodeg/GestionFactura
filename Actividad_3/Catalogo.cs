using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    class Catalogo
    {
        private List<Producto> listadoProductos;

        internal List<Producto> ListadoProductos { get => listadoProductos; set => listadoProductos = value; }

        public Catalogo()
        {
            this.ListadoProductos = new List<Producto>();
        }

        public void Agregar(Producto prod)
        {
            ListadoProductos.Add(prod);
        }

        public Producto Buscar(int codigo)
        {
            //Lambda & Query expression//
            //retorna el primer elemento que cumpla con la condicion
            return ListadoProductos.Where(prod => prod.Codigo == codigo).Single();
        }
        public static Catalogo Cargar()
        {
            var listaProd = new Catalogo();
            listaProd.Agregar(new Producto(1, "Coca", 100));
            listaProd.Agregar(new Producto(2, "Celular", 10000));
            listaProd.Agregar(new Producto(3, "Pan", 120));
            listaProd.Agregar(new Producto(4, "Nafta", 500));
            listaProd.Agregar(new Producto(5, "Yogur", 75));
            return listaProd;
        }
    }

}
