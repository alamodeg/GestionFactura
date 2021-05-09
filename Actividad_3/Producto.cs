using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    class Producto
    {
        private int codigo;
        private string descripcion;
        private float precio;

        public Producto(int codigo, string descripcion, float precio)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
