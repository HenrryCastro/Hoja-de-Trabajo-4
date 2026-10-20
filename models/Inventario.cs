using System;

namespace Hoja_de_Trabajo_4.models
{
    public class Inventario
    {
        private Producto cabeza;

        public void AgregarProducto(string codigo, string nombre, double precio)
        {
            Producto nuevo = new Producto(codigo, nombre, precio);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Producto actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            Console.WriteLine($"Producto '{nombre}' agregado exitosamente al inventario.");
        }

        public void BuscarPorCodigo(string codigo)
        {
            Producto actual = cabeza;
            while (actual != null)
            {
                if (actual.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n--- Producto Encontrado ---");
                    Console.WriteLine($"Código: {actual.Codigo}");
                    Console.WriteLine($"Nombre: {actual.Nombre}");
                    Console.WriteLine($"Precio: ${actual.Precio:F2}");
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine($"\nNo se encontró ningún producto con el código '{codigo}'.");
        }

        public void MostrarInventario()
        {
            Producto actual = cabeza;
            Console.WriteLine("\n--- Inventario Completo de Productos ---");
            if (actual == null)
            {
                Console.WriteLine("El inventario está vacío.");
                return;
            }

            while (actual != null)
            {
                Console.WriteLine($"[Código: {actual.Codigo}] - {actual.Nombre} - ${actual.Precio:F2}");
                actual = actual.Siguiente;
            }
        }
    }
}