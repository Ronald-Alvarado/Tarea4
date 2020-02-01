using System;

namespace InventarioTienda
{
    public class ClaseTienda
    {
        public float Precio { get; set; }
        public int Unidades { get; set; }
        public String Nombre { get; set; }

        public ClaseTienda()
        {
            Precio = 0;
            Unidades = 0;
            Nombre = string.Empty;
        }

        public ClaseTienda(float precio, int unidades, String nombre)
        {
            Precio = precio;
            Unidades = unidades;
            Nombre = nombre;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventario de una Tienda\n");
        }
    }
}

