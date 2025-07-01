using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<Sucursal> Sucursales { get; set; }
        public Tienda(string nombre, string direccion, string telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Sucursales = new List<Sucursal>();
        }
        public void AgregarSucursal(Sucursal sucursal)
        {
            Sucursales.Add(sucursal);
        }   
    }
}
