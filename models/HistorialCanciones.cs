using System;

namespace Hoja_de_Trabajo_4.models
{
    public class HistorialCanciones
    {
        private Cancion cabeza;
        private Cancion actual;

        public void AgregarCancion(string titulo, string artista)
        {
            Cancion nueva = new Cancion(titulo, artista);
            if (cabeza == null)
            {
                cabeza = nueva;
                actual = nueva;
            }
            else
            {
                Cancion temp = cabeza;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nueva;
                nueva.Anterior = temp;
            }
            Console.WriteLine($"Canción '{titulo}' de {artista} agregada al historial.");
        }

        public void SiguienteCancion()
        {
            if (actual != null && actual.Siguiente != null)
            {
                actual = actual.Siguiente;
                Console.WriteLine($"\nReproduciendo siguiente: {actual.Titulo} - {actual.Artista}");
            }
            else
            {
                Console.WriteLine("\nYa estás en la última canción del historial.");
            }
        }

        public void CancionAnterior()
        {
            if (actual != null && actual.Anterior != null)
            {
                actual = actual.Anterior;
                Console.WriteLine($"\nRetrocediendo a: {actual.Titulo} - {actual.Artista}");
            }
            else
            {
                Console.WriteLine("\nYa estás en la primera canción del historial.");
            }
        }

        public void MostrarActual()
        {
            if (actual != null)
            {
                Console.WriteLine($"\nReproduciendo actualmente: {actual.Titulo} - {actual.Artista}");
            }
            else
            {
                Console.WriteLine("\nNo hay ninguna canción reproduciéndose.");
            }
        }

        public void MostrarListaCompleta()
        {
            Cancion temp = cabeza;
            Console.WriteLine("\n--- Historial Completo de Canciones ---");
            if (temp == null)
            {
                Console.WriteLine("El historial está vacío.");
                return;
            }

            while (temp != null)
            {
                string indicador = (temp == actual) ? " 🎵 [Reproduciendo]" : "";
                Console.WriteLine($"- {temp.Titulo} por {temp.Artista}{indicador}");
                temp = temp.Siguiente;
            }
        }
    }
}