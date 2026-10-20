using System;

namespace Hoja_de_Trabajo_4.models
{
    public class RegistroAsistencia
    {
        private Asistente cabeza;

        public void AgregarAsistente(string nombre)
        {
            Asistente nuevo = new Asistente(nombre);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Asistente actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            Console.WriteLine($"Asistente '{nombre}' registrado exitosamente.");
        }

        public void BuscarAsistente(string nombre)
        {
            Asistente actual = cabeza;
            while (actual != null)
            {
                if (actual.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n¡El empleado '{nombre}' SÍ se encuentra en el registro de asistencia!");
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine($"\nEl empleado '{nombre}' NO aparece en el registro de asistentes.");
        }

        public void MostrarLista()
        {
            Asistente actual = cabeza;
            Console.WriteLine("\n--- Lista Completa de Asistentes ---");
            if (actual == null)
            {
                Console.WriteLine("No hay asistentes registrados todavía.");
                return;
            }

            int numero = 1;
            while (actual != null)
            {
                Console.WriteLine($"{numero}. {actual.Nombre}");
                actual = actual.Siguiente;
                numero++;
            }
        }
    }
}