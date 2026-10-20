using System;
using Hoja_de_Trabajo_4.models;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("         MENÚ PRINCIPAL - HOJA DE TRABAJO 4       ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Ejercicio 1: Lista Simple de Estudiantes");
            Console.WriteLine("2. Ejercicio 2: Lista Simple de Números Enteros");
            Console.WriteLine("3. Ejercicio 3: Control de Inventarios (Productos)");
            Console.WriteLine("4. Ejercicio 4: Registro de Asistencia de Empleados");
            Console.WriteLine("5. Ejercicio 5: Historial de Canciones (Doble)");
            Console.WriteLine("6. Ejercicio 6: Historial de Navegador Web (Doble)");
            Console.WriteLine("7. Ejercicio 7: Agenda de Contactos (Doble)");
            Console.WriteLine("8. Salir");
            Console.WriteLine("==================================================");
            Console.Write("Seleccione una opción (1-8): ");

            string opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion)
            {
                case "1":
                    EjecutarEjercicio1();
                    break;
                case "2":
                    EjecutarEjercicio2();
                    break;
                case "3":
                    EjecutarEjercicio3();
                    break;
                case "4":
                    EjecutarEjercicio4();
                    break;
                case "5":
                    EjecutarEjercicio5();
                    break;
                case "6":
                    EjecutarEjercicio6();
                    break;
                case "7":
                    EjecutarEjercicio7();
                    break;
                case "8":
                    salir = true;
                    Console.WriteLine("¡Saliendo del programa con éxito!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione cualquier tecla para intentar de nuevo...");
                    Console.ReadKey();
                    break;
            }

            if (!salir && (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" || opcion == "5" || opcion == "6" || opcion == "7"))
            {
                Console.WriteLine("\nPresione cualquier tecla para regresar al menú principal...");
                Console.ReadKey();
            }
        }
    }

    static void EjecutarEjercicio1()
    {
        ListaEstudiantes lista = new ListaEstudiantes();
        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- EJERCICIO 1: LISTA DE ESTUDIANTES ---");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Mostrar estudiantes");
            Console.WriteLine("3. Contar estudiantes");
            Console.WriteLine("4. Volver al menú principal");
            Console.Write("Elija una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del estudiante: ");
                        string nombre = Console.ReadLine();
                        lista.InsertarAlFinal(nombre);
                        break;
                    case 2:
                        lista.MostrarEstudiantes();
                        break;
                    case 3:
                        lista.ContarEstudiantes();
                        break;
                }
            }
        } while (opcion != 4);
    }

    static void EjecutarEjercicio2()
    {
        ListaEnteros lista = new ListaEnteros();
        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- EJERCICIO 2: NÚMEROS ENTEROS ---");
            Console.WriteLine("1. Agregar número");
            Console.WriteLine("2. Mostrar números");
            Console.WriteLine("3. Calcular suma total");
            Console.WriteLine("4. Volver al menú principal");
            Console.Write("Elija una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un número entero: ");
                        if (int.TryParse(Console.ReadLine(), out int val))
                            lista.Agregar(val);
                        else
                            Console.WriteLine("Valor inválido.");
                        break;
                    case 2:
                        lista.Mostrar();
                        break;
                    case 3:
                        lista.CalcularSuma();
                        break;
                }
            }
        } while (opcion != 4);
    }

    static void EjecutarEjercicio3()
    {
        Inventario inv = new Inventario();
        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- EJERCICIO 3: CONTROL DE INVENTARIO ---");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Buscar producto por código");
            Console.WriteLine("3. Mostrar inventario completo");
            Console.WriteLine("4. Volver al menú principal");
            Console.Write("Elija una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Código: ");
                        string cod = Console.ReadLine();
                        Console.Write("Nombre: ");
                        string nom = Console.ReadLine();
                        Console.Write("Precio: ");
                        if (double.TryParse(Console.ReadLine(), out double precio))
                            inv.AgregarProducto(cod, nom, precio);
                        else
                            Console.WriteLine("Precio inválido.");
                        break;
                    case 2:
                        Console.Write("Ingrese código a buscar: ");
                        inv.BuscarPorCodigo(Console.ReadLine());
                        break;
                    case 3:
                        inv.MostrarInventario();
                        break;
                }
            }
        } while (opcion != 4);
    }

    static void EjecutarEjercicio4()
    {
        RegistroAsistencia reg = new RegistroAsistencia();
        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- EJERCICIO 4: REGISTRO DE ASISTENCIA ---");
            Console.WriteLine("1. Registrar asistente");
            Console.WriteLine("2. Buscar asistente");
            Console.WriteLine("3. Mostrar lista de asistentes");
            Console.WriteLine("4. Volver al menú principal");
            Console.Write("Elija una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del empleado: ");
                        reg.AgregarAsistente(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Nombre a buscar: ");
                        reg.BuscarAsistente(Console.ReadLine());
                        break;
                    case 3:
                        reg.MostrarLista();
                        break;
                }
            }
        } while (opcion != 4);
    }

    static void EjecutarEjercicio5()
    {
        HistorialCanciones hist = new HistorialCanciones();
        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- EJERCICIO 5: HISTORIAL DE CANCIONES ---");
            Console.WriteLine("1. Agregar canción");
            Console.WriteLine("2. Siguiente canción");
            Console.WriteLine("3. Canción anterior");
            Console.WriteLine("4. Ver canción actual");
            Console.WriteLine("5. Mostrar historial completo");
            Console.WriteLine("6. Volver al menú principal");
            Console.Write("Elija una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Título: ");
                        string t = Console.ReadLine();
                        Console.Write("Artista: ");
                        string a = Console.ReadLine();
                        hist.AgregarCancion(t, a);
                        break;
                    case 2:
                        hist.SiguienteCancion();
                        break;
                    case 3:
                        hist.CancionAnterior();
                        break;
                    case 4:
                        hist.MostrarActual();
                        break;
                    case 5:
                        hist.MostrarListaCompleta();
                        break;
                }
            }
        } while (opcion != 6);
    }

    static void EjecutarEjercicio6()
    {
        HistorialNavegador nav = new HistorialNavegador();
        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- EJERCICIO 6: HISTORIAL DE NAVEGADOR ---");
            Console.WriteLine("1. Visitar nueva URL");
            Console.WriteLine("2. Ir atrás");
            Console.WriteLine("3. Ir adelante");
            Console.WriteLine("4. Mostrar página actual");
            Console.WriteLine("5. Volver al menú principal");
            Console.Write("Elija una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la URL (ej. google.com): ");
                        nav.VisitarPagina(Console.ReadLine());
                        break;
                    case 2:
                        nav.IrAtras();
                        break;
                    case 3:
                        nav.IrAdelante();
                        break;
                    case 4:
                        nav.MostrarPaginaActual();
                        break;
                }
            }
        } while (opcion != 5);
    }

    static void EjecutarEjercicio7()
    {
        AgendaContactos agenda = new AgendaContactos();
        int opcion = 0;
        do
        {
            Console.WriteLine("\n--- EJERCICIO 7: AGENDA DE CONTACTOS ---");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Buscar contacto");
            Console.WriteLine("3. Eliminar contacto");
            Console.WriteLine("4. Recorrer hacia adelante");
            Console.WriteLine("5. Recorrer hacia atrás");
            Console.WriteLine("6. Mostrar total de contactos");
            Console.WriteLine("7. Volver al menú principal");
            Console.Write("Elija una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nom = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        string tel = Console.ReadLine();
                        Console.Write("Correo: ");
                        string corr = Console.ReadLine();
                        agenda.Insertar(nom, tel, corr);
                        break;
                    case 2:
                        Console.Write("Nombre a buscar: ");
                        agenda.Buscar(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Nombre a eliminar: ");
                        agenda.Eliminar(Console.ReadLine());
                        break;
                    case 4:
                        agenda.RecorrerAdelante();
                        break;
                    case 5:
                        agenda.RecorrerAtras();
                        break;
                    case 6:
                        agenda.MostrarCantidad();
                        break;
                }
            }
        } while (opcion != 7);
    }
}