using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sucursal
    {
        public String nombre { get; set; }  
            
        public String direccion { get; set; }
        public String telefono { get; set; }
        public List<Producto> productos { get; set; }
        public Sucursal(string nombre, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.productos = new List<Producto>();
        }
    }
}
