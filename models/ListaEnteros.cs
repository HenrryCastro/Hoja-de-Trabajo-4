using System;

namespace Hoja_de_Trabajo_4.models
{
    public class ListaEnteros
    {
        private NodoEntero cabeza;

        public void Agregar(int valor)
        {
            NodoEntero nuevo = new NodoEntero(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoEntero actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            Console.WriteLine($"Número {valor} agregado correctamente.");
        }

        public void Mostrar()
        {
            NodoEntero actual = cabeza;
            Console.Write("\nNúmeros en orden de inserción: ");
            if (actual == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            while (actual != null)
            {
                Console.Write($"{actual.Valor} ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        public void CalcularSuma()
        {
            int suma = 0;
            NodoEntero actual = cabeza;
            while (actual != null)
            {
                suma += actual.Valor;
                actual = actual.Siguiente;
            }
            Console.WriteLine($"\nLa suma total de los elementos es: {suma}");
        }
    }
}