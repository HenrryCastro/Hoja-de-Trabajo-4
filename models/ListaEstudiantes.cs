using System;

namespace Hoja_de_Trabajo_4.models
{
    public class ListaEstudiantes
    {
        private NodoEstudiante cabeza;

        public void InsertarAlFinal(string nombre)
        {
            NodoEstudiante nuevo = new NodoEstudiante(nombre);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoEstudiante actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            Console.WriteLine($"Estudiante '{nombre}' agregado exitosamente.");
        }

        public void MostrarEstudiantes()
        {
            NodoEstudiante actual = cabeza;
            Console.WriteLine("\n--- Lista de Estudiantes Registrados ---");
            if (actual == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            while (actual != null)
            {
                Console.WriteLine($"- {actual.Nombre}");
                actual = actual.Siguiente;
            }
        }

        public void ContarEstudiantes()
        {
            int contador = 0;
            NodoEstudiante actual = cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            Console.WriteLine($"\nTotal de estudiantes en la lista: {contador}");
        }
    }
}