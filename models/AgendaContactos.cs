using System;

namespace Hoja_de_Trabajo_4.models
{
    public class AgendaContactos
    {
        private Contacto cabeza;
        private int contador = 0;

        public void Insertar(string nombre, string telefono, string correo)
        {
            Contacto nuevo = new Contacto(nombre, telefono, correo);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Contacto temp = cabeza;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
                nuevo.Anterior = temp;
            }
            contador++;
            Console.WriteLine($"Contacto '{nombre}' agregado exitosamente a la agenda.");
        }

        public void Buscar(string nombre)
        {
            Contacto temp = cabeza;
            while (temp != null)
            {
                if (temp.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n--- Contacto Encontrado ---");
                    Console.WriteLine($"Nombre: {temp.Nombre}");
                    Console.WriteLine($"Teléfono: {temp.Telefono}");
                    Console.WriteLine($"Correo: {temp.Correo}");
                    return;
                }
                temp = temp.Siguiente;
            }
            Console.WriteLine($"\nNo se encontró ningún contacto con el nombre '{nombre}'.");
        }

        public void Eliminar(string nombre)
        {
            Contacto temp = cabeza;
            while (temp != null)
            {
                if (temp.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    if (temp.Anterior != null)
                    {
                        temp.Anterior.Siguiente = temp.Siguiente;
                    }
                    else
                    {
                        cabeza = temp.Siguiente; // Era el primer elemento
                    }

                    if (temp.Siguiente != null)
                    {
                        temp.Siguiente.Anterior = temp.Anterior;
                    }

                    contador--;
                    Console.WriteLine($"\nContacto '{nombre}' eliminado correctamente.");
                    return;
                }
                temp = temp.Siguiente;
            }
            Console.WriteLine($"\nNo se encontró el contacto '{nombre}' para eliminar.");
        }

        public void RecorrerAdelante()
        {
            Contacto temp = cabeza;
            Console.WriteLine("\n--- Agenda de Contactos (Adelante) ---");
            if (temp == null)
            {
                Console.WriteLine("La agenda está vacía.");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine($"• {temp.Nombre} | Tel: {temp.Telefono} | Correo: {temp.Correo}");
                temp = temp.Siguiente;
            }
        }

        public void RecorrerAtras()
        {
            Contacto temp = cabeza;
            if (temp == null)
            {
                Console.WriteLine("\nLa agenda está vacía.");
                return;
            }

            // Ir al final de la lista
            while (temp.Siguiente != null)
            {
                temp = temp.Siguiente;
            }

            Console.WriteLine("\n--- Agenda de Contactos (Atrás hacia Adelante) ---");
            while (temp != null)
            {
                Console.WriteLine($"• {temp.Nombre} | Tel: {temp.Telefono} | Correo: {temp.Correo}");
                temp = temp.Anterior;
            }
        }

        public void MostrarCantidad()
        {
            Console.WriteLine($"\nTotal de contactos almacenados en la agenda: {contador}");
        }
    }
}