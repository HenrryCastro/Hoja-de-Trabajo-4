using System;

namespace Hoja_de_Trabajo_4.models
{
    public class HistorialNavegador
    {
        private NodoPagina actual;

        public void VisitarPagina(string url)
        {
            NodoPagina nueva = new NodoPagina(url);
            if (actual == null)
            {
                actual = nueva;
            }
            else
            {
                actual.Siguiente = nueva;
                nueva.Anterior = actual;
                actual = nueva;
            }
            Console.WriteLine($"Navegando a: {url}");
        }

        public void IrAtras()
        {
            if (actual != null && actual.Anterior != null)
            {
                actual = actual.Anterior;
                Console.WriteLine($"\nRetrocediendo a: {actual.Url}");
            }
            else
            {
                Console.WriteLine("\nNo hay páginas anteriores en el historial.");
            }
        }

        public void IrAdelante()
        {
            if (actual != null && actual.Siguiente != null)
            {
                actual = actual.Siguiente;
                Console.WriteLine($"\nAvanzando a: {actual.Url}");
            }
            else
            {
                Console.WriteLine("\nNo hay páginas siguientes en el historial.");
            }
        }

        public void MostrarPaginaActual()
        {
            if (actual != null)
            {
                Console.WriteLine($"\nPágina actual: {actual.Url}");
            }
            else
            {
                Console.WriteLine("\nEl historial está vacío.");
            }
        }
    }
}